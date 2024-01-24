using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanLe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            if (tuoi >= 18)
            {
                Console.WriteLine("******** Ban da vao game ********");
            }
            else
            {
                Console.WriteLine("Ban chua du tuoi de choi game");
                Environment.Exit(0);
            }

            Console.WriteLine("Moi ban nap tien : ");
            int tienNap = int.Parse(Console.ReadLine());
            Console.WriteLine("So tien hien tai cua ban la: " + tienNap);

            int luaChon;

            Console.WriteLine("=================================");
            Console.WriteLine("********* Moi ban chon **********");
            Console.WriteLine(">>>      1. Nhan 1 de chon le");
            Console.WriteLine(">>>      2. Nhan 2 de chon chan");
            Console.WriteLine(">>>      3. Thoat");
            Console.WriteLine("=================================");

            Console.WriteLine(">> Moi ban chon chan hoac le << ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    Console.WriteLine(">>>   Ban da chon le   <<<");
                    Console.WriteLine("---------------------------------");
                    //Console.WriteLine("Moi ban nap tien : ");
                    //int tienNap = int.Parse(Console.ReadLine());

                    //Console.WriteLine("So tien hien tai cua ban la: " + tienNap );
                    Console.WriteLine("Moi ban nhap so tien cuoc: ");
                    int tienCuoc = int.Parse(Console.ReadLine());
                    int tienConLai = tienNap - tienCuoc;
                    Console.WriteLine("So tien con lai sau khi cuoc la: " + tienConLai);
                    Console.WriteLine("-------VUI LONG DOI KET QUA--------");
                    // random 
                    Random random = new Random();
                    int soThuNhat, soThuHai, soThuBa;
                    do
                    {
                        soThuNhat = random.Next(1, 10);
                        soThuHai = random.Next(1, 10);
                        soThuBa = random.Next(1, 10);
                    } while (soThuNhat == soThuHai || soThuNhat == soThuBa || soThuHai == soThuBa);

                    int tong = soThuNhat + soThuHai + soThuBa;


                    if (tong % 2 == 0)
                    {
                        Console.WriteLine($"Tong cua ba so ({soThuNhat} + {soThuHai} + {soThuBa}) la 'CHAN'");
                        Console.WriteLine("===============================");
                        Console.WriteLine(">>>Chuc mung ban da thang game<<<");
                        int tienThang = tienNap + tienCuoc;
                        Console.WriteLine("So tien hien tai cua ban la :" + tienThang);
                    }
                    else
                    {
                        Console.WriteLine($"Tong cua ba so ({soThuNhat} + {soThuHai} + {soThuBa}) la 'LE'");
                        Console.WriteLine("===============================");
                        Console.WriteLine(">>>Ban da thua game<<<");
                        int tienThua = tienNap - tienCuoc;
                        Console.WriteLine("So tien hien tai cua ban la :" + tienThua);
                    }

                    break;
                    
                case 2:
                    Console.WriteLine(">>>   Ban da chon chan   <<<");
                    Console.WriteLine("---------------------------------");
                    //Console.WriteLine("Moi ban nap tien : ");
                    //int tienNap = int.Parse(Console.ReadLine());
                    //Console.WriteLine("So tien hien tai cua ban la: " + tienNap );
                    Console.WriteLine("Moi ban nhap so tien cuoc: ");
                    int tienCuoc1 = int.Parse(Console.ReadLine());
                    int tienConLai1 = tienNap - tienCuoc1;
                    Console.WriteLine("So tien con lai sau khi cuoc la: " + tienConLai1);
                    Console.WriteLine("-------VUI LONG DOI KET QUA--------");
                    // random 
                    Random random1 = new Random();
                    int soThuNhat1, soThuHai1, soThuBa1;
                    do
                    {
                        soThuNhat1 = random1.Next(1, 10);
                        soThuHai1 = random1.Next(1, 10);
                        soThuBa1 = random1.Next(1, 10);
                    } while (soThuNhat1 == soThuHai1 || soThuNhat1 == soThuBa1 || soThuHai1 == soThuBa1);

                    int tong1 = soThuNhat1 + soThuHai1 + soThuBa1;


                    if (tong1 % 2 == 0)
                    {
                        Console.WriteLine($"Tong cua ba so ({soThuNhat1} + {soThuHai1} + {soThuBa1}) la 'CHAN'");
                        Console.WriteLine("===============================");
                        Console.WriteLine(">>>Chuc mung ban da thang game<<<");
                        int tienThang1 = tienNap + tienCuoc1;
                        Console.WriteLine("So tien hien tai cua ban la :" + tienThang1);
                    }
                    else
                    {
                        Console.WriteLine($"Tong cua ba so ({soThuNhat1} + {soThuHai1} + {soThuBa1}) la 'LE'");
                        Console.WriteLine("===============================");
                        Console.WriteLine(">>>Ban da thua game<<<");
                        int tienThua1 = tienNap - tienCuoc1;
                        Console.WriteLine("So tien hien tai cua ban la :" + tienThua1);
                    }
                    break;
                case 3:
                    Console.WriteLine(">>> THOAT <<<");
                    break;
                default:
                    Console.WriteLine("Moi ban chon lai tu 1 - 3");
                    break;
            }

            Console.ReadKey();
        }
    }
}
