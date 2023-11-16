using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab6_7
{
    public class CKhoiNangKhieu : CThiSinh
    {
        public double m_diemToan;
        public double m_diemNangKhieu;
        public double DiemToan
        {
            get { return m_diemToan; }
            set { m_diemToan = value; }
        }
        public double DiemNangKhieu
        {
            get { return m_diemNangKhieu; }
            set { m_diemNangKhieu = value; }
        }

        public CKhoiNangKhieu() { }
        public CKhoiNangKhieu(string ma, string ten, double diemToan, double diemNangKhieu)
        {
            MaTS = ma;
            TenTS = ten;
            DiemToan = diemToan;
            DiemNangKhieu = diemNangKhieu;
        }
        public override double tongDiem()
        {
            return DiemToan + DiemNangKhieu * 2;
        }
        public override KieuKetQua ketQua()
        {
            if (tongDiem() >= 17)
                return KieuKetQua.Dat;
            else return KieuKetQua.KhongDat;
        }
        public override bool laKhoiA()
        {
            return false;
        }
        public override bool laKhoiNangKhieu()
        {
            return true;
        }
    }
}
