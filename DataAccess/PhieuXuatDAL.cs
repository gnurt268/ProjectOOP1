using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ProjectOOP1.Entities;
namespace ProjectOOP1.DataAccess
{
    class PhieuXuatDAL
    {
        DataAccessHelper dah = new DataAccessHelper();
        public DataTable LoadPX()
        {
            string s = "Select * from PhieuXuat";
            return dah.get_DaTaTable(s);
        }
        public void Them(PhieuXuat px)
        {
            DateTime hientai = DateTime.Now;
            string ngaygio = hientai.ToString("MM/dd/yyyy hh:mm:ss tt");
            string s = "insert into PhieuXuat values('" + px.Mapx + "','" + px.Manvxuat + "','" + ngaygio + "','" + px.Banso + "')";
            dah.ThucThiCL(s);
        }
        public void Xoa(PhieuXuat px)
        {
            dah.ThucThiCL("delete from PhieuXuat where mapx='" + px.Mapx + "'");
        }
        public DataTable px(string mapx)
        {
            string caulenh = "select * from Phieuxuat where mapx='" + mapx + "'";
            return dah.get_DaTaTable(caulenh);
        }
        public int DemBanGhi(string mapx)
        {
            int banghi;
            banghi = dah.TongBanGhi("select * from phieuxuat where mapx='" + mapx + "' ");
            return banghi;
        }
    }
}
