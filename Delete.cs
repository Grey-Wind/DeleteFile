using System;
using System.IO;

namespace Delete
{
    public static class DeleteFile
    {
        public static void Delete(string name)
        {
            if (Directory.Exists(name))
            {
                // 如果是文件夹，删除文件夹及其内容|If it is a folder, delete the folder and its contents
                Directory.Delete(name, true);
                Console.WriteLine("已成功删除文件夹：" + name);
                Console.WriteLine("The folder was successfully deleted:：" + name);
            }
            else if (File.Exists(name))
            {
                // 如果是文件，删除文件|If it is a file, delete the file
                File.Delete(name);
                Console.WriteLine("已成功删除文件：" + name);
                Console.WriteLine("The file was successfully deleted:" + name);
            }
            else
            {
                Console.WriteLine("文件或文件夹不存在：" + name);
                Console.WriteLine("File or folder does not exist:" + name);
            }
        }
    }
}

