using System;
using System.Text;
using System.Threading.Tasks;

namespace thuyanh123.session_4
{
    internal class Ex
    {
        // Bài 1: Giải phương trình bậc 2
        static void Bai_1()
        {
            Console.WriteLine("========== BÀI 1 ==========");
            Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC 2");

            Console.Write("Nhập a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    else
                        Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình có một nghiệm x = " + x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }

            Console.WriteLine();
        }


        // Bài 2: Kiểm tra số chẵn hoặc lẻ
        static void Bai_2()
        {
            Console.WriteLine("========== BÀI 2 ==========");
            Console.WriteLine("KIỂM TRA SỐ CHẴN HAY LẺ");

            Console.Write("Nhập một số nguyên: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine(n + " là số chẵn.");
            else
                Console.WriteLine(n + " là số lẻ.");

            Console.WriteLine();
        }


        // Bài 3: Tìm số lớn nhất trong 3 số
        static void Bai_3()
        {
            Console.WriteLine("========== BÀI 3 ==========");
            Console.WriteLine("TÌM SỐ LỚN NHẤT TRONG 3 SỐ");

            Console.Write("Nhập số thứ nhất: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số thứ ba: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            Console.WriteLine("Số lớn nhất là: " + max);

            Console.WriteLine();
        }


        // Bài 4: Kiểm tra loại tam giác
        static void Bai_4()
        {
            Console.WriteLine("========== BÀI 4 ==========");
            Console.WriteLine("KIỂM TRA LOẠI TAM GIÁC");

            Console.Write("Nhập cạnh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Cạnh phải lớn hơn 0.");
            }
            else if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Ba cạnh không tạo thành tam giác.");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác đều.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Đây là tam giác cân.");
            }
            else
            {
                Console.WriteLine("Đây là tam giác thường.");
            }

            Console.WriteLine();
        }


        // Bài 5: Xác định góc phần tư của điểm
        static void Bai_5()
        {
            Console.WriteLine("========== BÀI 5 ==========");
            Console.WriteLine("XÁC ĐỊNH GÓC PHẦN TƯ CỦA ĐIỂM");

            Console.Write("Nhập giá trị X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập giá trị Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Điểm (" + x + ", " + y + ") nằm ở góc phần tư thứ nhất.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Điểm (" + x + ", " + y + ") nằm ở góc phần tư thứ hai.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Điểm (" + x + ", " + y + ") nằm ở góc phần tư thứ ba.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Điểm (" + x + ", " + y + ") nằm ở góc phần tư thứ tư.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Điểm nằm tại gốc tọa độ.");
            }
            else if (x == 0)
            {
                Console.WriteLine("Điểm nằm trên trục Y.");
            }
            else
            {
                Console.WriteLine("Điểm nằm trên trục X.");
            }

            Console.WriteLine();
        }


        // Main
        public static void Main_2(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();

            Console.ReadKey();
        }
    }
}