using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SaS2.Save.Editor
{
    public class SaS2XnbReader : IDisposable
    {
        private readonly ContentManager _contentManager;

        public SaS2XnbReader(string contentPath)
        {
            var services = new GameServiceContainer();
            var graphicsDeviceService = GraphicsDeviceService.AddRef(IntPtr.Zero, 800, 600);
            services.AddService<IGraphicsDeviceService>(graphicsDeviceService);

            _contentManager = new ContentManager(services, contentPath);
        }

        public void ConvertXnbToPngAndWriteToStream(string xnbFileName, Stream pngStream)
        {
            var xnbTexture = _contentManager.Load<Texture2D>(xnbFileName.Replace(".xnb", ""));

            xnbTexture.SaveAsPng(pngStream, xnbTexture.Width, xnbTexture.Height);
        }

        public void Dispose()
        {
            _contentManager.Dispose();
        }
    }
}
