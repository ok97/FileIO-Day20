﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_IOStream
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIO.CreateFile();
            FileIO.CheckFileExixt();
            FileIO.ReadFileLine();

            Console.ReadLine();
        }
    }
}