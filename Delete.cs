using System.IO;

namespace JetBrainsActivation
{
    public static class DeleteFile
    {
        // 删除文件或文件夹的函数
        public static void Delete(string name)
        {
            if (Directory.Exists(name))
            {
                // 如果是文件夹，删除文件夹及其内容
                Directory.Delete(name, true);
            }
            else if (File.Exists(name))
            {
                // 如果是文件，删除文件
                File.Delete(name);
            }
        }
    }
}

