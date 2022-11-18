using System.IO;
namespace CS28_File
{

    static void ListFileDirectory(string path)
    {
        String[] directories = System.IO.Directory.GetDirectories(path);
        String[] files = System.IO.Directory.GetFiles(path);
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
        foreach (var directory in directories)
        {
            Console.WriteLine(directory);
            ListFileDirectory(directory); // Đệ quy
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} bytes ",
                        d.TotalSize);
                }
            }
            DriveInfo dr = new DriveInfo("C:/");
            System.Console.WriteLine($"{dr.Name}");
            //Directory
            string path = "ABC";

            //Exists(path) - kiem tra file co ton tai hay k
            if (Directory.Exists(path))
            {
                System.Console.WriteLine("Ton tai");
            }
            else
            {
                System.Console.WriteLine("Khong ton tai");
            }
            //CreateDirectory(path)
            // Directory.CreateDirectory(path);
            //Delete(path)
            Directory.Delete(path);
            //GetFiles - lay tat ca file trong thu muc
            var files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                System.Console.WriteLine(item);
            }
            //GetDirectories - Lay tat ca cac thu muc trong thu muc
            //Move(thu muc nguon, thu muc dich)
            ////
            
        }
    }
}