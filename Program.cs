namespace ConsoleApp1
{
    internal class Program
    {
        static string Menu()
        {
            Console.WriteLine("\n----------MENU----------");
            Console.WriteLine("1.Nhap DS");
            Console.WriteLine("2. Xuat DS");
            Console.WriteLine("3. Xuat loai hoa > 10 ki tu");
            Console.WriteLine("4. Xoa doi tuong theo dia phuong");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("Hay nhap su lua chon cua ban");
            string choose = Console.ReadLine();
            if (choose != "1" && choose != "2" && choose != "3"
                && choose != "4" && choose != "5")
            {
                Console.WriteLine("loi roi nhap lai di");
                return Menu();
            }
            else return choose;
        }
        static void Main(string[] args)
        {
            service sv = new service();
            while (true)
            {
                switch (Menu()) 
                {
                    case "1":
                        sv.NhapDS(); break;
                    case "2":
                        sv.XuatDS(); break;
                    case "3":
                        sv.Xuatloaihoahon10kitu(); break;
                    case "4":
                        sv.XoaDT(); break;
                    case "5":
                        Environment.Exit(0); break;
                }
            }
            
        }
    }
}
