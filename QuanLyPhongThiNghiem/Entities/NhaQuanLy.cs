using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongThiNghiem.Entities
{
    class NhaQuanLy : NhanVien
    {
        public int SoNgayCong { get; set; }
        public float BacLuong { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So Ngay Cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Bac Luong: ");
            BacLuong = float.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So Ngay Cong: {0}", SoNgayCong);
            Console.WriteLine("Bac Luong: {0}", BacLuong);
        }
        public override double TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }
    }
}
