﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using GUI;

namespace GUI

{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        
        {
 
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Home());
        }
    }
}
