using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemNguoiDung : Form
    {
        private static frmThemNguoiDung _Instances = null;

        public static frmThemNguoiDung Instances
        {
            get
            {
                if (_Instances == null)
                    _Instances = new frmThemNguoiDung();
                return frmThemNguoiDung._Instances; 
            }
            set { frmThemNguoiDung._Instances = value; }
        }

        private frmThemNguoiDung()
        {
            InitializeComponent();
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void frmThemNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instances = null;
        }
    }
}
