namespace SaS2.Save.Editor.Controls
{
    public class ImageSource
    {
        public class ImageSourceOnImageAddEventArgs(string imageKey) : EventArgs
        {
            public readonly string imageKey = imageKey;
        }

        public static event EventHandler<ImageSourceOnImageAddEventArgs> OnImageAdd;
        public static Dictionary<string, Image> ImageList { get; private set; } = [];

        private static void AddImage(string imageKey, Image image)
        {
            lock (ImageList)
            {
                ImageList.Add(imageKey, image);
            }

            OnImageAdd?.Invoke(null, new ImageSourceOnImageAddEventArgs(imageKey));
        }

        public static Image FramedImage(string imageKey, int frameIndex, Size imageSize)
        {
            // ToDo: save different sizes
            var framedImageKey = $"framed_{imageKey}";

            if (ImageList.ContainsKey(framedImageKey))
            {
                return ImageList[framedImageKey];
            }

            if (!ImageList.ContainsKey(imageKey))
            {
                throw new KeyNotFoundException($"Image with key {imageKey} is not found");
            }

            var frameKey = $"frame_{frameIndex}";

            if (!ImageList.ContainsKey(frameKey))
            {
                throw new KeyNotFoundException($"Frame image with key {frameKey} is not found");
            }

            var newImage = new Bitmap(imageSize.Width, imageSize.Height);

            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(ImageList[frameKey], 0, 0, imageSize.Width, imageSize.Height);
                graphics.DrawImage(ImageList[imageKey], imageSize.Width / 4, imageSize.Height / 4, imageSize.Width / 2, imageSize.Height / 2);
            }

            AddImage(framedImageKey, newImage);

            return newImage;
        }

        public static void InitFromXnb(string itemsXnbPath, string interfaceXnbPath, List<SaS2LootDef> lootDefs)
        {
            using var xnbReader = new SaS2XnbReader(Path.GetDirectoryName(itemsXnbPath) ?? Path.GetDirectoryName(interfaceXnbPath) ?? "");

            using (var imageStream = new MemoryStream())
            {
                xnbReader.ConvertXnbToPngAndWriteToStream(Path.GetFileName(itemsXnbPath), imageStream);

                using var itemsImage = new Bitmap(imageStream);

                // Items
                Parallel.ForEach(lootDefs, itemInfo =>
                {
                    var xPos = itemInfo.img % 32 * 128;
                    var yPos = itemInfo.img / 32 * 128;

                    var croppedImage = CloneImage(itemsImage, new Rectangle(xPos, yPos, 128, 128));

                    AddImage(itemInfo.name, croppedImage);
                });
            }

            using (var imageStream = new MemoryStream())
            {
                xnbReader.ConvertXnbToPngAndWriteToStream(Path.GetFileName(interfaceXnbPath), imageStream);

                using var interfaceImage = new Bitmap(imageStream);

                // Upgrades

                Parallel.For(0, 10, upgrade =>
                {
                    var xPos = 640 + upgrade * 64;
                    var yPos = 640;

                    var croppedImage = CloneImage(interfaceImage, new Rectangle(xPos, yPos, 64, 64));

                    AddImage($"upgrade_{upgrade + 1}", croppedImage);
                });

                // Item groups
                var itemGroupPos = new Point[] {
                    new(384, 0),
                    new(384, 128),
                    new(384, 256),
                    new(384, 384),
                    new(384, 512),
                    new(384, 768),
                    new(512, 512),
                    new(384, 1152),
                    new(512, 256),
                    new(512, 384),
                    new(512, 640),
                    new(384, 1280),
                };

                Parallel.For(0, (int)SaS2ItemGroupType.TotalCount, i =>
                {
                    var xPos = itemGroupPos[i].X;
                    var yPos = itemGroupPos[i].Y;

                    var croppedImage = CloneImage(interfaceImage, new Rectangle(xPos, yPos, 128, 128));

                    AddImage($"item_group_{i}", croppedImage);
                });

                // Frames (Count from Interface image)
                Parallel.For(0, 10, i =>
                {
                    var xPos = 0;
                    var yPos = i * 128;

                    Bitmap? croppedImage = null;

                    lock (interfaceImage)
                    {
                        croppedImage = interfaceImage.Clone(new Rectangle(xPos, yPos, 128, 128), interfaceImage.PixelFormat);
                    }

                    AddImage($"frame_{i}", croppedImage);
                });
            }
        }

        public static Bitmap CloneImage(Image source, Rectangle section)
        {
            var newImage = new Bitmap(section.Width, section.Height);

            lock (source)
            {
                using var g = Graphics.FromImage(newImage);

                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
            }

            return newImage;
        }
    }
}
