using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class service
    {
        List<Hoa>list = new List<Hoa>();
        public service()
        {
            list=new List<Hoa>();
        }
        public void NhapDS() 
        {
            Console.WriteLine("Ban muon nhap bao nhieu loai hoa");
            int soluong = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soluong; i++) 
            {
                Hoa ho = new Hoa();
                Console.WriteLine("Nhap id: ");
                ho.ID1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap ten");
                ho.Ten = Console.ReadLine();
                Console.WriteLine("Nhap dia phuong: ");
                ho.DiaPhuong1 = Console.ReadLine();
                list.Add(ho);
            }
            Console.WriteLine("ban muon nhap nua ko?(nhan Y de tiep tuc)");
            string choose = Console.ReadLine();
            if (choose == "Y") NhapDS();
            else return;
        }
        public void XuatDS()
        {
            if(list.Count > 0) 
            {
                Console.WriteLine("list dang rong, hay nhap vao di");
                NhapDS();
                XuatDS();
            }
            foreach(var item in list)
            {
                item.inthongtin();
            }
        }
        public void Xuatloaihoahon10kitu()
        {
            if(list.Count > 0)
            {
                Console.WriteLine("list dang rong, hay nhap vao di");
                NhapDS();
                XuatDS();
            }
            foreach(var item in list)
            {
                if(item.Ten.Length>10 )item.inthongtin();
            }
        }
        public void XoaDT()
        {
            Console.WriteLine("Nhap ma loai hoa ma ban muon xoa");
            string diaphuongz = Console.ReadLine();
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].DiaPhuong1==diaphuongz)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            XuatDS();
        }

    }
}
