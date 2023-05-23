using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DTO.Object;

namespace GUI2
{
    static public class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DangNhap());
            Application.Run(new DashBoard());


            
            //SinhVienBLL dsSinhVien = new SinhVienBLL();
            //dsSinhVien.Load();

        }
    }
}
