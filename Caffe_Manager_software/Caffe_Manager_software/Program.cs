﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caffe_Manager_software
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            Application.Run(new frmAdmin());      

            List<NhanVien> memberList = new List<NhanVien>();
        }
    }
}
