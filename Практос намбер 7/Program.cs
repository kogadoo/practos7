using System;

namespace Практос_намбер_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("Этот компьютер");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

                    Console.SetCursorPosition(0, 2);

                    DriveInfo[] drives = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in drives)
                    {
                        Console.Write("  " + drive.Name);
                        Console.WriteLine("  " + drive.TotalSize / 1073741824 + " Гб   Cвободно: " + drive.TotalFreeSpace / 1073741824 + " ГБ ");
                    }

                    int pos = Strelki.Strelkii(1, drives.Length + 2);

                    Papki.Dirs(drives[pos - 2].Name);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}