using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuyanh123.Session_6
{
    internal class _20_EXs
    {
        static void Main_6(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_2();
        }
        static void Bai_1()
        {
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());

            int ketQua = TinhTong(a, b);

            Console.WriteLine("Tổng = " + ketQua);
        }

        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static void Bai_2()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            if (KiemTraChan(n))
                Console.WriteLine("Đây là số chẵn");
            else
                Console.WriteLine("Đây là số lẻ");
        }

        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        static void Bai_3()
        {
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Số lớn nhất = " + TimMax(a, b, c));
        }

        static int TimMax(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            return max;
        }
     
        static void Bai_4()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Giai thừa = " + TinhGiaiThua(n));
        }

        static long TinhGiaiThua(int n)
        {
            long ketQua = 1;

            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }

            return ketQua;
        }

        static void Bai_5()
        {
            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();

            Console.WriteLine("Chuỗi đảo ngược: " + DaoNguocChuoi(input));
        }

        static string DaoNguocChuoi(string input)
        {
            char[] mang = input.ToCharArray();

            Array.Reverse(mang);

            return new string(mang);
        }

        static void Bai_6()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            if (KiemTraNguyenTo(n))
                Console.WriteLine("Là số nguyên tố");
            else
                Console.WriteLine("Không phải số nguyên tố");
        }

        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static void Bai_7()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            InFibonacci(n);
        }

        static void InFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine();
        }

        static void Bai_8()
        {
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();

            Console.WriteLine("Số nguyên âm = " + DemNguyenAm(s));
        }

        static int DemNguyenAm(string s)
        {
            int dem = 0;

            foreach (char c in s)
            {
                char x = char.ToLower(c);

                if (x == 'a' || x == 'e' || x == 'i' ||
                    x == 'o' || x == 'u')
                {
                    dem++;
                }
            }

            return dem;
        }

        static void Bai_9()
        {
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhập y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Kết quả = " + TinhLuyThua(x, y));
        }

        static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;

            for (int i = 1; i <= y; i++)
            {
                ketQua *= x;
            }

            return ketQua;
        }

        static void Bai_10()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Trung bình = " + TinhTrungBinh(arr));
        }

        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
            }

            return (double)tong / arr.Length;
        }

        static void Bai_11()
        {
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();

            if (KiemTraDoiXung(s))
                Console.WriteLine("Chuỗi đối xứng");
            else
                Console.WriteLine("Chuỗi không đối xứng");
        }

        static bool KiemTraDoiXung(string s)
        {
            int trai = 0;
            int phai = s.Length - 1;

            while (trai < phai)
            {
                if (s[trai] != s[phai])
                    return false;

                trai++;
                phai--;
            }

            return true;
        }

        static void Bai_12()
        {
            Console.Write("Nhập độ C: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Độ F = " + CelsiusToFahrenheit(c));
        }

        static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        static void Bai_13()
        {
            int[] arr = { 5, 2, 8, 1, 9 };

            Console.WriteLine("Số nhỏ nhất = " + TimMin(arr));
        }

        static int TimMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        static void Bai_14()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tổng các chữ số = " + TongCacChuSo(n));
        }

        static int TongCacChuSo(int n)
        {
            n = Math.Abs(n);

            int tong = 0;

            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }

            return tong;
        }

        static void Bai_15()
        {
            int[] arr = { 5, 2, 8, 1, 9 };

            SapXepMang(arr);

            Console.Write("Mảng sau khi sắp xếp: ");

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }

        static void SapXepMang(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Bai_16()
        {
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();

            Console.WriteLine("Kết quả: " + XoaTrungLap(s));
        }

        static string XoaTrungLap(string s)
        {
            string ketQua = "";

            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }

            return ketQua;
        }

        static void Bai_17()
        {
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("UCLN = " + UCLN(a, b));
        }

        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }

        static void Bai_18()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhị phân = " + DecimalToBinary(n));
        }

        static string DecimalToBinary(int n)
        {
            if (n == 0)
                return "0";

            string ketQua = "";

            while (n > 0)
            {
                int du = n % 2;

                ketQua = du + ketQua;

                n /= 2;
            }

            return ketQua;
        }

        static void Bai_19()
        {
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());

            if (KiemTraNamNhuan(year))
                Console.WriteLine("Là năm nhuận");
            else
                Console.WriteLine("Không phải năm nhuận");
        }

        static bool KiemTraNamNhuan(int year)
        {
            if (year % 400 == 0)
                return true;

            if (year % 100 == 0)
                return false;

            return year % 4 == 0;
        }
     
        static void Bai_20()
        {
            Console.Write("Nhập câu: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Số từ = " + DemSoTu(sentence));
        }

        static int DemSoTu(string sentence)
        {
            string[] mangTu = sentence.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            return mangTu.Length;
        }
    }
}

   
    


 
