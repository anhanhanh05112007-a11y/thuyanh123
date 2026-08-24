using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuyanh123.session_4
{
    internal class baitap4
    {
        static void Bai_1()
        {
            Console.WriteLine("Bài 1");
            Console.WriteLine("Nhập vào chỉ số điện cũ (kWh):");
            float csd_cu = float.Parse(Console.ReadLine());
            float csd_moi;
            do
            {
                Console.WriteLine("Nhập chỉ số điện mới (kWh):");
                csd_moi = float.Parse(Console.ReadLine());
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn hoặc bằng chỉ số điện cũ.");
            } while (true);
            float tieuThu = csd_moi - csd_cu;
            const decimal b1 = 1806m;
            const decimal b2 = 1866m;
            const decimal b3 = 2167m;
            const decimal b4 = 2729m;
            const decimal b5 = 3050m;
            decimal tienDien;
            if (tieuThu <= 50 && tieuThu > 0)
            {
                tienDien = (decimal)tieuThu * b1;
            }
            else if (tieuThu <= 100)
            {
                tienDien = 50 * b1 + (decimal)(tieuThu - 50) * b2;
            }
            else if (tieuThu <= 200)
            {
                tienDien = 50 * b1 + 50 * b2 + (decimal)(tieuThu - 100) * b3;
            }
            else if (tieuThu <= 300)
            {
                tienDien = 50 * b1 + 50 * b2 + 100 * b3 + (decimal)(tieuThu - 200) * b4;
            }
            else
            {
                tienDien = 50 * b1 + 50 * b2 + 100 * b3 + 100 * b4 + (decimal)(tieuThu - 300) * b5;
            }

            float vat = 0.08f;
            decimal tienVat = tienDien * (decimal)vat;
            Console.WriteLine($"Số kWh tiêu thụ:{tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:C} VNĐ");
            Console.WriteLine($"Tiền thuế VAT: {tienVat:C} VNĐ");
            Console.WriteLine($"Tổng tiền phải thanh toán: {(tienDien + tienVat):C} VNĐ");
        }
        static void Bai_2()
        {
            Console.WriteLine("Bài 2");
            Console.Write("Chiều cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine());

            double bmi = canNang / Math.Pow(chieuCao, 2);

            string ketQua;

            if (bmi < 18.5)
            {
                ketQua = "Gầy (Thiếu cân)";
            }
            else if (bmi < 23)
            {
                ketQua = "Bình thường (Lý tưởng)";
            }
            else if (bmi < 25)
            {
                ketQua = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                ketQua = "Béo phì";
            }

            double canNangMin = 18.5 * Math.Pow(chieuCao, 2);
            double canNangMax = 22.9 * Math.Pow(chieuCao, 2);

            Console.WriteLine("\nChỉ số BMI: " + bmi.ToString("F2"));
            Console.WriteLine("Phân loại: " + ketQua);
            Console.WriteLine("Cân nặng lý tưởng: "
                + canNangMin.ToString("F2")
                + " kg - "
                + canNangMax.ToString("F2") + " kg");
        }
        static void Bai_3()
        {
            Console.Write("Nhap so tien VNĐ: ");
            decimal tienVND = decimal.Parse(Console.ReadLine());

            Console.WriteLine("1 - USD");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - JPY");
            Console.WriteLine("4 - GBP");

            Console.Write("Chon ngoai te: ");
            int luaChon = int.Parse(Console.ReadLine());

            CurrencyType loaiTien;
            decimal tyGia = 0;

            switch (luaChon)
            {
                case 1:
                    loaiTien = CurrencyType.USD;
                    tyGia = 25400;
                    break;

                case 2:
                    loaiTien = CurrencyType.EUR;
                    tyGia = 27200;
                    break;

                case 3:
                    loaiTien = CurrencyType.JPY;
                    tyGia = 165;
                    break;

                case 4:
                    loaiTien = CurrencyType.GBP;
                    tyGia = 32100;
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }

            decimal phi = tienVND * 0.5m / 100;
            decimal tienSauPhi = tienVND - phi;
            decimal tienNgoaiTe = tienSauPhi / tyGia;

            Console.WriteLine("\n--- KET QUA ---");
            Console.WriteLine("Loai tien: " + loaiTien);
            Console.WriteLine("Phi dich vu: " + phi.ToString("#,##0") + " VNĐ");
            Console.WriteLine("Tien VND tinh doi: " + tienSauPhi.ToString("#,##0") + " VNĐ");
            Console.WriteLine("So tien nhan duoc: " + tienNgoaiTe.ToString("F2") + " " + loaiTien);
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            Console.ReadKey();

        }
    }
}
