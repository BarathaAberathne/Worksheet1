using System;
using System.ServiceModel;
using TrueMarbleLibrary;
namespace TrueMarbleData
{

    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,UseSynchronizationContext = false,InstanceContextMode = InstanceContextMode.Single)])]
    internal class TMDataControllerImpl : ITMDataController
    {
        int width;
        int height;
        int x;
        int y;

        public TMDataControllerImpl()
        {
        }
        public int GetTileWidth()
        {
            int width;
            int height;
            TrueMarble.GetTileSize(out width, out height);
            return width;
        }

        public int GetTileHeight()
        {
            int width;
            int height;
            TrueMarble.GetTileSize(out width, out height);
            return height;
        }

        public int GetNumTilesAcross(int zoom) {
            TrueMarble.GetNumTiles( zoom, out x, out y);
            return x;

        }

        public int GetNumTilesDown(int zoom)
        {
            int x;
            int y;
            TrueMarble.GetNumTiles(zoom, out x, out y);
            return y;
        }

        public byte[] LoadTile(int zoom, int x, int y)
        {
            int theight = this.GetTileHeight();
            int twidth = this.GetTileWidth();
            int bufSize = twidth * theight * 3;
            int jpgSize;
            byte[] arr = new byte[bufSize];

            TrueMarble.GetTileImageAsRawJPG(zoom, x, y,out arr, bufSize,out jpgSize);
            return arr;
        }
    }
}
