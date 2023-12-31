﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Практос_намбер_7
{
    internal class Papki
    {
        public static void Dirs(string s)
        {
            if (Directory.Exists(s))
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Папка" + fileName);
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("".PadRight(120, '-'));
                    Console.WriteLine($"{"Название",15} {"Дата создания",38} {"Тип",19}");

                    string[] Directories = Directory.GetDirectories(s);
                    for (int i1 = 0; i1 < Directories.Length; i1++)
                    {
                        string Direct = Directories[i1];
                        string name = Path.GetFileName(Direct);
                        if (name.Length >= 25)
                        {
                            name = name.Substring(0, 25);
                        }
                        Console.Write("  " + name);
                        Console.SetCursorPosition(30, i1 + 3);
                        Console.WriteLine("\t\t" + Directory.GetCreationTime(Direct));
                    }
                    string[] files = Directory.GetFiles(s);
                    for (int i2 = 0; i2 < files.Length; i2++)
                    {
                        string file = files[i2];
                        string fileName = Path.GetFileName(file); // Получаем имя файла без пути

                        Console.Write("  " + fileName);

                        Console.SetCursorPosition(30, i2 + 3 + Directories.Length);
                        string fileExtension = Path.GetExtension(file);
                        Console.WriteLine("\t\t" + Directory.GetCreationTime(file) + "\t\t" + fileExtension);
                    }

                    int position = Strelki.Strelkii(2, Directories.Length + files.Length + 3);

                    if (position == -99)
                        return;
                    else if (position - 3 < Directories.Length)
                        Dirs(Directories[position - 3]);
                    else
                        Dirs(files[position - 3 - Directories.Length]);
                }
            }
            else
            {
                Process.Start(new ProcessStartInfo {FileName = s, UseShellExecute = true});
            }
        }
    }
}
