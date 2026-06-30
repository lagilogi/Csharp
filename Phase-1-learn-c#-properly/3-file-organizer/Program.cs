

namespace FileOrganizerApp
{
    static class Program
    {
        static void Main()
        {
            string rootPath = @"C:\tmp\";

            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(rootPath, "*.jpg", SearchOption.TopDirectoryOnly);

            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }

            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
            Console.WriteLine($"File count: {files.Count()}");
        }

    }
}
