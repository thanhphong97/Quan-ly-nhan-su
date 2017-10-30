using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    static class Program
    {
        public static clsNhanVien_DTO NhanVien_Login = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegisterMessageBoxManager();
            Application.Run(new frmMain());
            
            UnregisterMessageBoxManager();
        }

        private static void UnregisterMessageBoxManager()
        {
            MessageBoxManager.Unregister();
        }

        private static void RegisterMessageBoxManager()
        {
            MessageBoxManager.Yes = "Có";
            MessageBoxManager.No = "Không";
            MessageBoxManager.Register();
        }
    }
}
