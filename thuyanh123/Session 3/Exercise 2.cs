using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuyanh123.session_4
{
    internal class Exercise2
    {
        enum CurrencyType { USD, EUR, JPY, GBP }
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
        // nhập dữ liệu
        Console.Write("Nhập số tiền VNĐ: ");
            decimal soTienVND = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int luaChon = int.Parse(Console.ReadLine());

            // Chuyển số người dùng chọn (1,2,3,4) thành giá trị enum tương ứng
            CurrencyType loaiTien = (CurrencyType)(luaChon - 1); // vì enum bắt đầu từ 0

            // tỷ giá cố định
            decimal tyGiaUSD = 25400m;
            decimal tyGiaEUR = 27200m;
            decimal tyGiaJPY = 165m;
            decimal tyGiaGBP = 32100m;

            // tính phí dịch vụ 0,55
            decimal phiDichVu = soTienVND * 0.005m;
            decimal soTienSauPhi = soTienVND - phiDichVu;

            // Quy đổi ra tiền tệ tương ứng
            decimal soTienNgoaiTe = 0;
            string kyHieu = "";

            // switch-case: chọn công thức tính theo loại tiền đã chọn
            switch (loaiTien)
            {
                case CurrencyType.USD:
                    soTienNgoaiTe = soTienSauPhi / tyGiaUSD;
                    kyHieu = "USD";
                    break;
                case CurrencyType.EUR:
                    soTienNgoaiTe = soTienSauPhi / tyGiaEUR;
                    kyHieu = "EUR";
                    break;
                case CurrencyType.JPY:
                    soTienNgoaiTe = soTienSauPhi / tyGiaJPY;
                    kyHieu = "JPY";
                    break;
                case CurrencyType.GBP:
                    soTienNgoaiTe = soTienSauPhi / tyGiaGBP;
                    kyHieu = "GBP";
                    break;
            }

            // Kết quả
            Console.WriteLine($"\nPhí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {soTienSauPhi:N0} VNĐ");
            Console.WriteLine($"Số tiền {kyHieu} nhận được: {soTienNgoaiTe:F2} {kyHieu}");
        }
        static void Bai_4()
        {
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            string chuoiNgay = Console.ReadLine();

            DateTime ngaySinh;

            bool hopLe = DateTime.TryParseExact(
                chuoiNgay,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngaySinh);

            if (!hopLe)
            {
                Console.WriteLine("Ngay sinh khong hop le!");
                return;
            }

            DateTime homNay = DateTime.Now.Date;

            int tuoi = homNay.Year - ngaySinh.Year;

            if (homNay < ngaySinh.AddYears(tuoi))
            {
                tuoi--;
            }

            TimeSpan daSong = homNay - ngaySinh;

            DateTime sinhNhat = new DateTime(
                homNay.Year,
                ngaySinh.Month,
                ngaySinh.Day);

            if (sinhNhat < homNay)
            {
                sinhNhat = sinhNhat.AddYears(1);
            }

            TimeSpan conLai = sinhNhat - homNay;

            Console.WriteLine("\nTuoi hien tai: " + tuoi + " tuoi");
            Console.WriteLine("Da song: " + (int)daSong.TotalDays + " ngay");
            Console.WriteLine("Sinh nhat tiep theo con: "
                + (int)conLai.TotalDays + " ngay");
        }
        static void Bai_5()
        {
            Console.Write("Diem Lap trinh C#: ");
            double diem1 = double.Parse(Console.ReadLine());

            Console.Write("So tin chi: ");
            int tc1 = int.Parse(Console.ReadLine());

            Console.Write("Diem Toan roi rac: ");
            double diem2 = double.Parse(Console.ReadLine());

            Console.Write("So tin chi: ");
            int tc2 = int.Parse(Console.ReadLine());

            Console.Write("Diem Tieng Anh: ");
            double diem3 = double.Parse(Console.ReadLine());

            Console.Write("So tin chi: ");
            int tc3 = int.Parse(Console.ReadLine());

            double tongTinChi = tc1 + tc2 + tc3;

            double diemTB = (diem1 * tc1
                           + diem2 * tc2
                           + diem3 * tc3) / tongTinChi;

            char diemChu;
            double gpa;
            string xepLoai;

            if (diemTB >= 8.5)
            {
                diemChu = 'A';
                gpa = 4.0;
                xepLoai = "Xuat sac / Gioi";
            }
            else if (diemTB >= 7.0)
            {
                diemChu = 'B';
                gpa = 3.0;
                xepLoai = "Kha";
            }
            else if (diemTB >= 5.5)
            {
                diemChu = 'C';
                gpa = 2.0;
                xepLoai = "Trung binh";
            }
            else if (diemTB >= 4.0)
            {
                diemChu = 'D';
                gpa = 1.0;
                xepLoai = "Yeu";
            }
            else
            {
                diemChu = 'F';
                gpa = 0.0;
                xepLoai = "Kem (Truot)";
            }

            Console.WriteLine("\n--- KET QUA ---");
            Console.WriteLine("Diem TB thang 10: " + diemTB.ToString("F2"));
            Console.WriteLine("Diem chu: " + diemChu);
            Console.WriteLine("GPA thang 4: " + gpa.ToString("F1"));
            Console.WriteLine("Xep loai: " + xepLoai);
        }
       

        public static void Main(string[] args)
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
