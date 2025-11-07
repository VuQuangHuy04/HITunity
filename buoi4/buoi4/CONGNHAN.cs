using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{     public enum ChucVu
        {
            TruongNhom,
            PhoNhom,
            CongNhanBac3,
            CongNhanBac2,
            CongNhanBac1,
            Khac
        }
    internal class CONGNHAN : Person
    {   public string maCongNhan { get; set; }
        public ChucVu chucVu { get; set; }
        public CONGNHAN(string macongnhan,ChucVu chucvu,string name, int age, string address): base(name,age,address){
               maCongNhan= macongnhan;
               chucVu= chucvu;
         }
        private double x = 8000000;
        public CONGNHAN() { }
        public double TinhLuong()
        {
            switch (chucVu)
            {
                case ChucVu.TruongNhom:
                    return 3.0 * x;
                case ChucVu.PhoNhom:
                    return 2.5 * x;
                case ChucVu.CongNhanBac3 :
                    return 2 * x;
                case ChucVu.CongNhanBac2:
                    return 1.5 * x;
                case ChucVu.CongNhanBac1 :
                    return 1.2 * x;
                default:
                    return 1 * x;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " id: " + maCongNhan+ " Chuc vu: " + chucVu;
        }
    }
}
