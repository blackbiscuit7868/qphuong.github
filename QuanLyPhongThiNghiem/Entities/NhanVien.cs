using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongThiNghiem.Entities
{
    //cách đặt tên biến, phương thức, lớp trong c#
    //Pascal case; Lớp, Project, Properties, Event vd NhanVien: viết hoa ký tự đầu của các từ
    //camel case: biến cục bộ, tham số vd: nhanVien: viết thường ký tự đầu của từ đầu tiên, các từ tiếp theo viết hoa ký tự đầu
    //Upper case: hằng số
    abstract class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string BangCap { get; set; }
        public string ChucVu { get; set; }
        public virtual void Nhap()
        {
            Console.Write("Ho Ten: ");
            HoTen = Console.ReadLine();

            NamSinh = Helpers.NhapNgayThang();

            Console.Write("Bang cap: ");
            BangCap = Console.ReadLine();
            Console.Write("Chuc Vu: ");
            ChucVu = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("Nam Sinh {0}", NamSinh.ToShortDateString());
            Console.WriteLine("Bang Cap: {0}", BangCap);
            Console.WriteLine("Chuc vu: {0}", ChucVu);
        }
        public abstract double TinhLuong();
    }
}
