using QuanLyPhongThiNghiem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongThiNghiem
{
    class ChuongTrinhQuanLy
    {
        List<NhanVien> danhSach;
        public ChuongTrinhQuanLy()
        {
            danhSach = new List<NhanVien>();
        }
        public void Nhap()
        {
            do
            {
                NhanVien nhanVien = null;
                Console.WriteLine("1. Nhap nhan vien PTN");
                Console.WriteLine("2. Nhap nha quan ly");
                Console.WriteLine("3. Nhap nhà khoa học");
                Console.WriteLine("0. Thoát nhập nhân viên");
                int luaChon = int.Parse(Console.ReadLine());
                if (luaChon == 0)
                {
                    break;
                }
                switch (luaChon)
                {
                    case 1:
                        nhanVien = new NhanVienPhongThiNghiem();
                        break;
                    case 2:
                        nhanVien = new NhaQuanLy();
                        break;
                    case 3:
                        nhanVien = new NhaKhoaHoc();
                        break;
                    default:
                        break;
                }
                nhanVien.Nhap();
                danhSach.Add(nhanVien);
            } while (true);
        }
        public void Xuat()
        {
            foreach (var nhanVien in danhSach)
            {
                Console.WriteLine("---------------NEXT-------------");
                nhanVien.Xuat();
            }
        }
        public void TinhTongLuong()
        {
            double luongNhaKhoaHoc, luongNhaQuanLy, luongNhanVienPTN;

            luongNhaKhoaHoc = danhSach.OfType<NhaKhoaHoc>().Sum(p => p.TinhLuong());
            luongNhaQuanLy = danhSach.OfType<NhaQuanLy>().Sum(x => x.TinhLuong());
            luongNhanVienPTN = danhSach.OfType<NhanVienPhongThiNghiem>().Sum(x => x.TinhLuong());

            Console.WriteLine("Luong nha khoa học: {0}", luongNhaKhoaHoc);
            Console.WriteLine("Luong nha quan ly: {0}", luongNhaQuanLy - luongNhaKhoaHoc);
            Console.WriteLine("Luong nhan vien PTN: {0}", luongNhanVienPTN);
        }
    }
}
