using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongThiNghiem
{
    class Program
    {
        //debug chương trình: f9 tạo điểm dừng, f10: chạy dòng lệnh tiếp theo, f11: chạy vào hàm con, f5: tiếp tục
        //một số phím tắt thường dùng
        //ctrl + k + c: comment code
        //ctrl + k +u: uncomment code
        //ctrl+ k +d: format code
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ChuongTrinhQuanLy chuongTrinh = new ChuongTrinhQuanLy();
            MenuChuongTrinh(chuongTrinh);
            Console.ReadLine();
        }

        private static void MenuChuongTrinh(ChuongTrinhQuanLy chuongTrinh)
        {
            do
            {
                Console.WriteLine("1. Nhập danh sách");
                Console.WriteLine("2. Xuất danh sách");
                Console.WriteLine("3. Tổng lương theo đối tương");
                Console.WriteLine("0. Thoát");
                int luaChon = int.Parse(Console.ReadLine());
                if (luaChon == 0)
                {
                    break;
                }
                switch (luaChon)
                {
                    case 1:
                        chuongTrinh.Nhap();
                        break;
                    case 2:
                        chuongTrinh.Xuat();
                        break;
                    case 3:
                        chuongTrinh.TinhTongLuong();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
