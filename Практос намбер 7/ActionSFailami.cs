using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практос_намбер_7
{
    internal class ActionSFailami
    {
        public static void Action1(string path)
        {
            string name = Console.ReadLine();
            File.Create(path + "\\" + name).Close();
        }
        public static void Action2(string path)
        {
            string name = Console.ReadLine();
            Directory.CreateDirectory(path + "\\" + name);
        }
        public static void Action3(string path)
        {
            string name = Console.ReadLine();
            Directory.Delete(path + "\\" + name, true);
        }
        public static void Action4(string path)
        {
            string name = Console.ReadLine();
            File.Delete(path + "\\" + name);
        } 
    }
}

