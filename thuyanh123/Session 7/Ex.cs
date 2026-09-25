using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuyanh123.Session_7
{
    internal class Ex
    {
        static Random rd = new Random();
        public static void Main(string[] args)
        {
            int c;
            do
            {
                Console.WriteLine("\n1.Bai1  2.Bai2  3.Bai3  0.Thoat");
                Console.Write("Chon: ");
                c = int.Parse(Console.ReadLine());
                if (c == 1) Bai_1();
                else if (c == 2) Bai_2();
                else if (c == 3) Bai_3();
            } while (c != 0);
        }

        //BAI 1: Cac ham xu ly mang 
        static int[] TaoMangNgauNhien(int n, int min, int max)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rd.Next(min, max + 1);
            return arr;
        }

        static void InMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // 1. Tinh trung binh cong
        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
                tong += arr[i];
            return (double)tong / arr.Length;
        }

        // 2. Kiem tra gia tri co ton tai trong mang
        static bool KiemTraTonTai(int[] arr, int giaTri)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == giaTri) return true;
            return false;
        }

        // 3. Tim vi tri cua mot phan tu
        static int TimViTri(int[] arr, int giaTri)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == giaTri) return i;
            return -1;
        }

        // 4. Xoa mot phan tu khoi mang (tra ve mang moi, nho hon 1 phan tu)
        static int[] XoaPhanTu(int[] arr, int giaTri)
        {
            int viTri = TimViTri(arr, giaTri);
            if (viTri == -1) return arr;

            int[] ketQua = new int[arr.Length - 1];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == viTri) continue;
                ketQua[k++] = arr[i];
            }
            return ketQua;
        }

        // 5. Tim gia tri lon nhat va nho nhat
        static void TimMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
        }

        // 6. Dao nguoc mang
        static int[] DaoNguocMang(int[] arr)
        {
            int[] ketQua = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                ketQua[i] = arr[arr.Length - 1 - i];
            return ketQua;
        }

        // 7. Tim cac gia tri bi trung
        static int[] TimGiaTriTrung(int[] arr)
        {
            int[] tam = new int[arr.Length];
            int soLuong = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        bool daCo = false;
                        for (int k = 0; k < soLuong; k++)
                            if (tam[k] == arr[i]) daCo = true;

                        if (!daCo) tam[soLuong++] = arr[i];
                    }
                }
            }

            int[] ketQua = new int[soLuong];
            for (int i = 0; i < soLuong; i++) ketQua[i] = tam[i];
            return ketQua;
        }

        // 8. Xoa cac phan tu trung, chi giu lai 1 gia tri duy nhat
        static int[] XoaTrungLap(int[] arr)
        {
            int[] tam = new int[arr.Length];
            int soLuong = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool daCo = false;
                for (int k = 0; k < soLuong; k++)
                    if (tam[k] == arr[i]) daCo = true;

                if (!daCo) tam[soLuong++] = arr[i];
            }

            int[] ketQua = new int[soLuong];
            for (int i = 0; i < soLuong; i++) ketQua[i] = tam[i];
            return ketQua;
        }

        static void Bai_1()
        {
            int[] mang = TaoMangNgauNhien(10, 1, 20);
            Console.Write("Mang: ");
            InMang(mang);

            Console.WriteLine("Trung binh: " + TinhTrungBinh(mang));

            Console.Write("Gia tri kiem tra ton tai: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(KiemTraTonTai(mang, x) ? "Co ton tai" : "Khong ton tai");

            Console.Write("Gia tri tim vi tri: ");
            int y = int.Parse(Console.ReadLine());
            int vt = TimViTri(mang, y);
            Console.WriteLine(vt != -1 ? "Vi tri: " + vt : "Khong tim thay");

            Console.Write("Gia tri can xoa: ");
            int z = int.Parse(Console.ReadLine());
            int[] mangSauXoa = XoaPhanTu(mang, z);
            Console.Write("Sau khi xoa: ");
            InMang(mangSauXoa);

            int max, min;
            TimMaxMin(mang, out max, out min);
            Console.WriteLine($"Max = {max}, Min = {min}");

            Console.Write("Dao nguoc: ");
            InMang(DaoNguocMang(mang));

            int[] trung = TimGiaTriTrung(mang);
            if (trung.Length > 0)
            {
                Console.Write("Gia tri bi trung: ");
                InMang(trung);
            }
            else Console.WriteLine("Mang khong co gia tri trung");

            Console.Write("Sau khi xoa trung lap: ");
            InMang(XoaTrungLap(mang));
        }

        //BAI 2: Bubble sort va Linear search 
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tam = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tam;
                    }
                }
            }
        }

        // Tach cau thanh mang cac tu (khong dung ham co san Split cho phan tach thu cong)
        static string[] TachTu(string cau)
        {
            List<string> danhSach = new List<string>();
            string tuHienTai = "";

            for (int i = 0; i < cau.Length; i++)
            {
                char ch = cau[i];
                if (char.IsLetterOrDigit(ch))
                {
                    tuHienTai += ch;
                }
                else if (tuHienTai.Length > 0)
                {
                    danhSach.Add(tuHienTai);
                    tuHienTai = "";
                }
            }
            if (tuHienTai.Length > 0) danhSach.Add(tuHienTai);

            return danhSach.ToArray();
        }

        // Tim kiem tuyen tinh: duyet tung phan tu cho den khi tim thay
        static int TimKiemTuyenTinh(string[] mangTu, string tuCanTim)
        {
            for (int i = 0; i < mangTu.Length; i++)
            {
                if (string.Equals(mangTu[i], tuCanTim, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        static void Bai_2()
        {
            int[] mang = new int[10];
            Console.WriteLine("Nhap 10 so nguyen:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"So thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(mang);
            Console.Write("Sau khi sap xep (Bubble sort): ");
            InMang(mang);

            Console.Write("\nNhap mot cau: ");
            string cau = Console.ReadLine();
            Console.Write("Nhap tu can tim: ");
            string tu = Console.ReadLine();

            string[] cacTu = TachTu(cau);
            int viTri = TimKiemTuyenTinh(cacTu, tu);

            Console.WriteLine(viTri != -1
                ? $"Tim thay tu \"{tu}\" tai vi tri {viTri} trong cau."
                : $"Khong tim thay tu \"{tu}\" trong cau.");
        }

        // BAI 3: Ma tran
        static int[,] TaoMaTranNgauNhien(int n, int m, int min, int max)
        {
            int[,] mt = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    mt[i, j] = rd.Next(min, max + 1);
            return mt;
        }

        static void InMaTran(int[,] mt)
        {
            int n = mt.GetLength(0);
            int m = mt.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(mt[i, j].ToString().PadLeft(5));
                Console.WriteLine();
            }
        }

        static int[] LayHang(int[,] mt, int hang)
        {
            int m = mt.GetLength(1);
            int[] ketQua = new int[m];
            for (int j = 0; j < m; j++)
                ketQua[j] = mt[hang, j];
            return ketQua;
        }

        static int[] LayCot(int[,] mt, int cot)
        {
            int n = mt.GetLength(0);
            int[] ketQua = new int[n];
            for (int i = 0; i < n; i++)
                ketQua[i] = mt[i, cot];
            return ketQua;
        }

        static int TimMaxMaTran(int[,] mt)
        {
            int max = mt[0, 0];
            int n = mt.GetLength(0);
            int m = mt.GetLength(1);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (mt[i, j] > max) max = mt[i, j];
            return max;
        }

        static int TimMinTrongMang(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min) min = arr[i];
            return min;
        }

        static int[,] ChuyenViMaTran(int[,] mt)
        {
            int n = mt.GetLength(0);
            int m = mt.GetLength(1);
            int[,] ketQua = new int[m, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    ketQua[j, i] = mt[i, j];
            return ketQua;
        }

        static void InDuongCheoChinh(int[,] mt)
        {
            int n = mt.GetLength(0);
            Console.Write("Duong cheo chinh: ");
            for (int i = 0; i < n; i++)
                Console.Write(mt[i, i] + " ");
            Console.WriteLine();
        }

        static void InDuongCheoPhu(int[,] mt)
        {
            int n = mt.GetLength(0);
            Console.Write("Duong cheo phu: ");
            for (int i = 0; i < n; i++)
                Console.Write(mt[i, n - 1 - i] + " ");
            Console.WriteLine();
        }

        static void Bai_3()
        {
            Console.Write("Nhap so hang N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot M: ");
            int m = int.Parse(Console.ReadLine());

            int[,] maTran = TaoMaTranNgauNhien(n, m, 1, 20);
            Console.WriteLine("Ma tran vua tao:");
            InMaTran(maTran);

            Console.Write($"Chi so hang can in (0-{n - 1}): ");
            int hang = int.Parse(Console.ReadLine());
            Console.Write("Hang " + hang + ": ");
            InMang(LayHang(maTran, hang));

            Console.Write($"Chi so cot can in (0-{m - 1}): ");
            int cot = int.Parse(Console.ReadLine());
            Console.Write("Cot " + cot + ": ");
            InMang(LayCot(maTran, cot));

            Console.WriteLine("Max ma tran: " + TimMaxMaTran(maTran));
            Console.WriteLine("Min hang " + hang + ": " + TimMinTrongMang(LayHang(maTran, hang)));
            Console.WriteLine("Min cot " + cot + ": " + TimMinTrongMang(LayCot(maTran, cot)));

            Console.WriteLine("Ma tran sau khi chuyen vi:");
            InMaTran(ChuyenViMaTran(maTran));

            if (n == m)
            {
                InDuongCheoChinh(maTran);
                InDuongCheoPhu(maTran);
            }
            else
            {
                Console.WriteLine("Ma tran khong vuong nen khong co duong cheo chinh/phu.");
            }
        }
    }
}
    
