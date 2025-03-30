using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Student
{
    public class clsDangNhap
    {   
        public clsDangNhap() { }
        public clsDangNhap(string tenDangNhap, string matKhau, string quyen)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.quyen = quyen;
        }

        public string tenDangNhap { get; set; }
        public string matKhau { get; set; }
        public string quyen { get; set; }


    }
}
