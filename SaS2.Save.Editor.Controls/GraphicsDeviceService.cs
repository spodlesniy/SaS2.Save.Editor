using Microsoft.Xna.Framework.Graphics;

namespace SaS2.Save.Editor
{
    public class GraphicsDeviceService : IGraphicsDeviceService
    {
        static GraphicsDeviceService? singletonInstance = null;
        static int referenceCount;

        public GraphicsDevice? GraphicsDevice { get; private set; }

        public event EventHandler<EventArgs> DeviceCreated;
        public event EventHandler<EventArgs> DeviceDisposing;
        public event EventHandler<EventArgs> DeviceReset;
        public event EventHandler<EventArgs> DeviceResetting;

        public GraphicsDeviceService(IntPtr windowHandle, int width, int height)
        {
            var parameters = new PresentationParameters
            {
                BackBufferWidth = Math.Max(width, 1),
                BackBufferHeight = Math.Max(height, 1),
                BackBufferFormat = SurfaceFormat.Color,
                DepthStencilFormat = DepthFormat.Depth24,
                DeviceWindowHandle = windowHandle,
                PresentationInterval = PresentInterval.Immediate,
                IsFullScreen = false
            };

            GraphicsDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, GraphicsProfile.Reach, parameters);
        }

        public static GraphicsDeviceService AddRef(IntPtr windowHandle, int width, int height)
        {
            if (referenceCount == 0 || singletonInstance == null)
            {
                singletonInstance = new GraphicsDeviceService(windowHandle, width, height);
            }

            referenceCount++;

            return singletonInstance;
        }

        public void Release(bool disposing)
        {
            referenceCount--;

            if (referenceCount == 0)
            {
                if (disposing)
                {
                    DeviceDisposing?.Invoke(this, EventArgs.Empty);

                    GraphicsDevice?.Dispose();
                }

                GraphicsDevice = null;
            }
        }
    }
}
