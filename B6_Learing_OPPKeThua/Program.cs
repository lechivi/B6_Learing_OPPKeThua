using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B6_Learing_OPPKeThua.common;

namespace B6_Learing_OPPKeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NhanVien nv1 = new NhanVien("001", DateTime.Now, "LeVi", "Male");
            //Console.WriteLine(nv1);

            NhanVien nv2 = new NhanVien("002", "lechivi", "male", DateTime.Now , 3f);
            //Console.WriteLine(nv2);
            nv2.OutputNhanVien();

            NhanVien nv3 = new NhanVien("003", new People("vichile", "male"), DateTime.Now, 3f);
            nv3.OutputNhanVien();

            //Viet base class People(name, gender, DOB)
            //Viet devired class CongNhan(hsl)
            //Viet ham tinh tuoi, tim CongNhan = ten, tim CongNhan co tuoi lon nhat
            //Viet devired class CanBo(hsl)
        }

    }
}
