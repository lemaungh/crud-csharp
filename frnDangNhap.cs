using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Student
{
    public partial class frmDangNhap: Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            DataProvider.getAllUser();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            bool isFound = false;

            foreach (var dangNhap in DataProvider.listDangNhap)
            {
                if (dangNhap.tenDangNhap == tenDangNhap && dangNhap.matKhau == matKhau)
                {
                    isFound = true; break;
                }
            }
            if (isFound == true) 
             { 
                  frmMain f = new frmMain(); 
                  f.ShowDialog();
             }
             else
             {
                   MessageBox.Show("Sai tai khoan hoac mat khau");
             }
        }
    }
}
