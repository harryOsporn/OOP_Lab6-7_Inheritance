using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab6_7
{
    public enum KieuKetQua { Dat, KhongDat }
    public class CThiSinh
    {
        public string m_MaTS;
        public string m_TenTS;

        public string MaTS
        {
            get { return m_MaTS; }
            set { m_MaTS = value; }
        }
        public string TenTS
        {
            get { return m_TenTS; }
            set { m_TenTS = value; }
        }
        public CThiSinh()
        {
        }

        public CThiSinh(string maTS, string tenTS)
        {
            m_MaTS = maTS;
            m_TenTS = tenTS;    
        }
        public virtual double tongDiem()
        {
            return 0;
        }
        public virtual KieuKetQua ketQua()
        {
            return KieuKetQua.KhongDat;
        }
        public virtual bool laKhoiA()
        {
            return false;
        }
        public virtual bool laKhoiNangKhieu() { return false; }

    }
}
