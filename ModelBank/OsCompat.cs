using System.Runtime.InteropServices;

namespace ModelBank {
    static class OsCompat {
        public static string LocalizedPath (string path) { // takes a Unix-formatted path
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                path = path.Replace('/','\\');
            }
            return path;
        }
    }
}