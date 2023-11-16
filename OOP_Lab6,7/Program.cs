using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            khoiTaoDSThiSinh();
            int thiSinhNK = getSoThiSinhKhoiNangKhieu(dsThiSinh);
            Console.WriteLine("So thi sinh nang khieu: " + thiSinhNK);
            
           
        }
    private static List<CThiSinh> dsThiSinh = new List<CThiSinh>();
    public static void khoiTaoDSThiSinh()
    {
        CThiSinh tsKhoiA1 = new CKhoiA("01", "Bomman", 6.5, 8, 8);
        CThiSinh tsKhoiA2 = new CKhoiA("02", "Hoang", 10, 5, 6);
        CThiSinh tsNK1 = new CKhoiNangKhieu("03", "Huy", 8, 10);
        CThiSinh tsNK2 = new CKhoiNangKhieu("04", "Hoa", 10, 9);

        dsThiSinh.Add(tsKhoiA1);
        dsThiSinh.Add(tsKhoiA2);
        dsThiSinh.Add(tsNK1);
        dsThiSinh.Add(tsNK2);
    }

    static int getSoThiSinhKhoiNangKhieu(List<CThiSinh> ds)
    {
        int count = 0;
        foreach (CThiSinh i in ds)
        {
            if (i.laKhoiNangKhieu().Equals(i.laKhoiA()))
            {
                count++;
            }
        }
        return count;
    }
}
}
