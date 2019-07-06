using System;
using System.Collections.Generic;
using System.IO;

namespace dotnetLib
{
    public static class FileUtils
    {
        private static void DelFiles(List<string> files)
        {
            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    DelFile(file);
                }
            }
        }
        public static void DelFile(string path)
        {
            File.Delete(path);
        }

        public static void DeleteFileOrDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            if (attr == FileAttributes.Directory)
            {
                Directory.Delete(path, true);
            }
            else
            {
                DelFile(path);
            }
        }
    }
}
