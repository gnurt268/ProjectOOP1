using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectOOP1.Entities;
using ProjectOOP1.DataAccess;
using System.Data;

namespace ProjectOOP1.Business
{
    class DangNhapBLL

    {
        DangNhapDAL bll = new DangNhapDAL();
        public bool KiemTra(string Tendangnhap, string matKhau)
        {
            return bll.KiemTra(Tendangnhap, matKhau);
        }
    }
}
