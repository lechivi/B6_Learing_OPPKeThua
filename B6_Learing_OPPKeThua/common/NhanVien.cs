using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_Learing_OPPKeThua.common
{
    internal class NhanVien : People 
    {
        //People la class co so (Base class)
        //NhanVien la class dan xuat (Derived class)

        private string maNV;
        private DateTime ngayLam;
        private float heSoLuong;

        //public NhanVien()
        //{
        //    this.maNV = " ";
        //    this.ngayLam = DateTime.Now;
        //}

        public NhanVien(string id, DateTime nvl, string name, string gender) : base(name, gender)
        {
            this.maNV = id;
            this.ngayLam = nvl;
        }

        public NhanVien(string maNV, string name, string gender, DateTime ngayLam, float heSoLuong) : base(name, gender)
        {
            this.maNV = maNV;
            this.ngayLam = ngayLam;
            this.heSoLuong = heSoLuong;
        }

        public NhanVien(string maNV, People nv, DateTime ngayLam, float heSoLuong) : base(nv.Name, nv.Gender)
        {
            this.maNV = maNV;
            this.ngayLam = ngayLam;
            this.heSoLuong = heSoLuong;
        }

        public override string ToString()
        {
            return "Ma NV: " + this.maNV + "\nTen NV: " + this.name + "\nGender: " + this.gender + "\nNgay vao lam: " 
                + this.ngayLam.ToString("dd/MM/yyyy") + "\nLuong: " + this.TinhLuongNV();
        }

        public void OutputNhanVien()
        {
            Console.WriteLine("Ma NV: " + this.maNV + "\nTen NV: " + this.name + "\nGender: " + this.gender + "\nNgay vao lam: " 
                + this.ngayLam.ToString("dd/MM/yyyy") + "\nLuong: " + this.TinhLuongNV());
        }

        public double TinhLuongNV()
        {
            //luong = hsl * 1.490.000 + 500.000;
            return this.heSoLuong * Constance.mucLuongCoBan + Constance.phuCapNV;
        }
    }
}
