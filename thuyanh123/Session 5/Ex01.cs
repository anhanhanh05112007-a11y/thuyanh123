using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuyanh123.Session_5
{
    internal class Ex01
    {
        static void Bangcuuchuong()
        {
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"Bảng nhân {i}");
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
        static void Bai_1()
        {
            // Bước 1: Nhập độ dài 3 cạnh
            Console.Write("Nhap canh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Bước 2: Kiểm tra 3 cạnh có tạo thành tam giác hay không
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Day khong phai la tam giac.");
            }
            else
            {
                // Bước 3: Nếu 3 cạnh bằng nhau
                if (a == b && b == c)
                {
                    Console.WriteLine("Equilateral - Tam giac deu");
                }

                // Bước 4: Nếu có 2 cạnh bằng nhau
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Isosceles - Tam giac can");
                }

                // Bước 5: Nếu 3 cạnh đều khác nhau
                else
                {
                    Console.WriteLine("Scalene - Tam giac thuong");
                }
            }
        }
        static void Bai_2()
        {
            // Biến sum dùng để lưu tổng
            double sum = 0;

            // Bước 1: Dùng vòng lặp để nhập 10 số
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Nhap so thu " + i + ": ");

                double number = Convert.ToDouble(Console.ReadLine());

                // Cộng số vừa nhập vào tổng
                sum = sum + number;
            }

            // Bước 2: Tính trung bình
            double average = sum / 10;

            // Bước 3: In kết quả
            Console.WriteLine();
            Console.WriteLine("Tong = " + sum);
            Console.WriteLine("Trung binh = " + average);
        }
        static void Bai_3()
        {

        }
               




        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bangcuuchuong();
            Bai_1();
            Bai_2();
            Bai_3();
        }
    }
}