using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int soLanLap;
            Console.WriteLine("Mời bạn nhập số lần bạn muốn chơi: ");
            soLanLap = int.Parse(Console.ReadLine());


            for (int i = 0; i < soLanLap; i++)
            {

                Console.WriteLine("------------------------");
                Console.WriteLine("TRÒ CHƠI CHẴN LẺ");
                Console.WriteLine("1. Bấm 1 để chơi");
                Console.WriteLine("------------------------");

                int luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("1. Bấm 1 để chơi");

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
                            Console.WriteLine($"Tổng của ba số({soThuNhat} + {soThuHai} + {soThuBa}) là 'CHẴN'");
                        }
                        else
                        {
                            Console.WriteLine($"Tổng của ba số ({soThuNhat} + {soThuHai} + {soThuBa}) là 'LẺ'");
                        }
                        break;
                    //case 2:
                    //    Console.WriteLine("Cảm ơn bạn đã sử dụng trò chơi :))");
                    //    break;
                    default:
                        Console.WriteLine("Mời bạn chọn lại 1 - 2");
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
