﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _19._11._2842_Tugas10
{
    public class Epson : IPrinter
    {
        public void Show(PrinterWindows printer)
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void Print(PrinterWindows printer)
        {
            Console.WriteLine("Epson printer printing...");
        }


    }
}
