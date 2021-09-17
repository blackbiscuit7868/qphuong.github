using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongThiNghiem
{
    class Helpers
    {
        public static DateTime NhapNgayThang()
        {
            do
            {
                Console.Write("Nam Sinh: ");
                DateTime namSinh;
                if (DateTime.TryParse(Console.ReadLine(), out namSinh))
                    return namSinh;
            } while (true);
        }
    }
}
