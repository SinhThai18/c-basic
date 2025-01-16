
internal class Program
{
    public class SinhVien 
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }

        public string NoiSinh { get; set; }
    }


    private static void Main(string[] args)
    {
        //var sanPham = new
        //{
        //    Ten = "iphone",
        //    Gia = "1000"
        //};

        ////sanPham.Ten = "asdkada"; loi khong gan duoc vi no chi doc

        //Console.WriteLine(sanPham.ToString());

        List<SinhVien> cacSinhVien = new List<SinhVien>()
        {
            new SinhVien {HoTen = "Thai",NamSinh = 2003, NoiSinh="Hung yen" },
            new SinhVien {HoTen = "dat",NamSinh = 2005, NoiSinh="Hung yen" },
            new SinhVien {HoTen = "duc",NamSinh = 2008, NoiSinh="truong my" },
            new SinhVien {HoTen = "ca",NamSinh = 2009, NoiSinh="thanh hoa" },
        };

        var sinhvien = from c in cacSinhVien
                       where c.NamSinh > 2006
                       select c;

        foreach (var c in sinhvien)
        {
            Console.WriteLine(c.HoTen + "-"+ c.NamSinh+"-"+c.NoiSinh);
        }

        Console.WriteLine("-------------------------------------");

        var sinhvien1 = from c in cacSinhVien
                        where c.NamSinh > 2006
                        select new
                        {
                            Ten = c.HoTen,
                            NamSinhr = c.NamSinh,
                            NoiSinhr = c.NoiSinh,
                        };
        foreach (var c in sinhvien1)
        {
            Console.WriteLine(c.Ten + "-" + c.NamSinhr + "-" + c.NoiSinhr);
        }


    }
}