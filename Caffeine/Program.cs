﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caffeine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Use at your own risk -kevinx
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
