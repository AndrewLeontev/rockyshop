using System;
using System.Runtime.InteropServices;

namespace RockyShop
{
    public static class WC
    {
        public static bool isWindows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        public static string ImagePath = isWindows ? @"\images\product\" : @"/images/product/";
        public static string SessionCart = "ShoppingCartSession";
    }
}
