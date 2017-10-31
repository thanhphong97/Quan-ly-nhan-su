using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucThemNguoiDung : UserControl
    {

       
        
        public ucThemNguoiDung()
        {
            InitializeComponent();
        }

        private void ucThemNguoiDung_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        

        

        
    }
}
