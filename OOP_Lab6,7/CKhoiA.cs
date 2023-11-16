using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab6_7
{
    public class CKhoiA: CThiSinh
    {
        public double m_DiemToan;
        public double m_DiemLy;
        public double m_DiemHoa;

        public double DiemToan
        {
            get { return m_DiemToan; }
            set { m_DiemToan = value;}
        }
        public double DiemLy
        {
            get { return m_DiemLy; }
            set { m_DiemLy = value;}
        }
        public double DiemHoa
        {
            get { return m_DiemHoa; }
            set { m_DiemHoa = value; }
        }
        public CKhoiA() { }
        public CKhoiA(string ma, string ten, double diemToan, double diemLy, double diemHoa)
        {
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
        }
        public override double tongDiem()
        {
            return DiemToan + DiemLy + DiemHoa;
        }
        public override KieuKetQua ketQua()
        {
            if (tongDiem() >= 18.5)
                return KieuKetQua.Dat;
            else return KieuKetQua.KhongDat;
        }
        public override bool laKhoiA() { return true; }
        public override bool laKhoiNangKhieu() { return false; }
    }
}
