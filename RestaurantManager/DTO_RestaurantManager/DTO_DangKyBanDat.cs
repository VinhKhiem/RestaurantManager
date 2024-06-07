using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_DangKyBanDat
    {
        public int maDK { get; set; }
        public int soLuongNguoi { get; set; }
        public int viTri { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }
        public DateTime thoiGian { get; set; }
        public int maKH { get;set; }
        // Constructor không tham số
        public DTO_DangKyBanDat()
        {
        }

        // Constructor với tham số
        public DTO_DangKyBanDat( int soLuongNguoi, int viTri, string ghiChu, DateTime thoiGian, int maKH)
        {
            this.soLuongNguoi = soLuongNguoi;
            this.viTri = viTri;
            this.ghiChu = ghiChu;
            this.thoiGian = thoiGian;
            this.maKH = maKH;
        }
        public DTO_DangKyBanDat(int maDK,int soLuongNguoi, int viTri, string ghiChu,bool trangThai, DateTime thoiGian, int maKH)
        {
            this.maDK = maDK;
            this.soLuongNguoi = soLuongNguoi;
            this.viTri = viTri;
            this.ghiChu = ghiChu;
            this.trangThai= trangThai;
            this.thoiGian = thoiGian;
            this.maKH = maKH;
        }
    }
}
