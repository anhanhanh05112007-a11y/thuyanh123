using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuyanh123.Session_8
{
    internal class Bai_9_giong_bai_8
    {
        static string dir = Path.Combine(Directory.GetCurrentDirectory(), "FileDemo");

        static string P(string name) => Path.Combine(dir, name);

        static void Title(string s)
        {
            Console.WriteLine();
            Console.WriteLine($"=== {s} ===");
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Directory.CreateDirectory(dir);

            Ex1(); Ex2(); Ex3(); Ex4(); Ex5(); Ex6(); Ex7(); Ex8();
            Ex9(); Ex10(); Ex11(); Ex12(); Ex13(); Ex14(); Ex15();

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        // 1. Tạo file rỗng
        static void Ex1()
        {
            Title("1. Tao file rong");
            string path = P("blank.txt");
            File.Create(path).Dispose();
            Console.WriteLine($"Da tao: {path} (ton tai: {File.Exists(path)})");
        }

        // 2. Xóa file
        static void Ex2()
        {
            Title("2. Xoa file");
            string path = P("blank.txt");
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Da xoa blank.txt");
            }
            Console.WriteLine($"Con ton tai: {File.Exists(path)}");
        }

        // 3. Tạo file và ghi text
        static void Ex3()
        {
            Title("3. Tao file va ghi text");
            File.WriteAllText(P("text.txt"), "Hello C#\nDay la dong thu hai.\n");
            Console.WriteLine("Da ghi vao text.txt");
        }

        // 4. Tạo file text rồi đọc
        static void Ex4()
        {
            Title("4. Tao file text va doc");
            File.WriteAllText(P("read.txt"), "Dong 1\nDong 2\nDong 3\n");
            Console.WriteLine(File.ReadAllText(P("read.txt")));
        }

        // 5. Ghi mảng chuỗi vào file
        static void Ex5()
        {
            Title("5. Ghi mang chuoi vao file");
            string[] arr = { "Apple", "Banana", "Cherry", "Durian", "Mango" };
            File.WriteAllLines(P("array.txt"), arr);
            Console.WriteLine("Noi dung array.txt:");
            foreach (string s in File.ReadAllLines(P("array.txt")))
                Console.WriteLine("  " + s);
        }

        // 6. Append text vào file có sẵn
        static void Ex6()
        {
            Title("6. Append text");
            File.AppendAllText(P("text.txt"), "Dong duoc noi them.\n");
            Console.WriteLine(File.ReadAllText(P("text.txt")));
        }

        // 7. Tạo, copy sang tên khác và hiển thị nội dung
        static void Ex7()
        {
            Title("7. Copy file va hien thi");
            File.WriteAllText(P("original.txt"), "Noi dung file goc.\n");
            File.Copy(P("original.txt"), P("copy.txt"), true);
            Console.WriteLine("Noi dung copy.txt:");
            Console.WriteLine(File.ReadAllText(P("copy.txt")));
        }

        // 8. Tạo file và move (đổi tên) trong cùng thư mục
        static void Ex8()
        {
            Title("8. Move file cung thu muc voi ten khac");
            string src = P("tomove.txt");
            string dst = P("moved.txt");
            File.WriteAllText(src, "File se bi di chuyen.\n");
            if (File.Exists(dst)) File.Delete(dst);
            File.Move(src, dst);
            Console.WriteLine($"tomove.txt ton tai: {File.Exists(src)}, moved.txt ton tai: {File.Exists(dst)}");
        }
        static string SampleFile()
        {
            string path = P("sample.txt");
            File.WriteAllLines(path, new[]
            {
            "Dong 1: Hello World 123",
            "Dong 2: C# Sharp 2026",
            "Dong 3: File IO",
            "Dong 4: Doc dong cuoi",
            "Dong 5: Ket thuc 99"
        });
            return path;
        }

        // 9. Đọc dòng đầu
        static void Ex9()
        {
            Title("9. Doc dong dau tien");
            using (StreamReader sr = new StreamReader(SampleFile()))
                Console.WriteLine(sr.ReadLine());
        }

        // 10. Đọc dòng cuối
        static void Ex10()
        {
            Title("10. Doc dong cuoi");
            Console.WriteLine(File.ReadLines(SampleFile()).Last());
        }

        // 11. Đọc n dòng cuối
        static void Ex11()
        {
            Title("11. Doc n dong cuoi");
            int n = 3;
            string[] lines = File.ReadAllLines(SampleFile());
            int start = Math.Max(0, lines.Length - n);
            for (int i = start; i < lines.Length; i++)
                Console.WriteLine(lines[i]);
        }

        // 12. Đọc một dòng cụ thể
        static void Ex12()
        {
            Title("12. Doc dong cu the");
            int lineNo = 3; // đếm từ 1
            string line = File.ReadLines(SampleFile()).Skip(lineNo - 1).FirstOrDefault();
            Console.WriteLine(line != null ? $"Dong {lineNo}: {line}" : "Dong khong ton tai");
        }

        // 13. Đếm số dòng
        static void Ex13()
        {
            Title("13. Dem so dong");
            Console.WriteLine("So dong: " + File.ReadLines(SampleFile()).Count());
        }

        // 14. In cấu trúc thư mục (gồm file)
        static void Ex14()
        {
            Title("14. Cau truc thu muc");
            Directory.CreateDirectory(Path.Combine(dir, "SubA", "SubB"));
            File.WriteAllText(Path.Combine(dir, "SubA", "a.txt"), "a");
            File.WriteAllText(Path.Combine(dir, "SubA", "SubB", "b.txt"), "b");
            Console.WriteLine(Path.GetFileName(dir) + "/");
            PrintTree(dir, "");
        }

        static void PrintTree(string folder, string indent)
        {
            var entries = Directory.GetDirectories(folder).Cast<string>()
                .Concat(Directory.GetFiles(folder)).ToArray();
            for (int i = 0; i < entries.Length; i++)
            {
                bool last = i == entries.Length - 1;
                string name = Path.GetFileName(entries[i]);
                bool isDir = Directory.Exists(entries[i]);
                Console.WriteLine(indent + (last ? "└── " : "├── ") + name + (isDir ? "/" : ""));
                if (isDir)
                    PrintTree(entries[i], indent + (last ? "    " : "│   "));
            }
        }

        // 15. Thống kê ký tự và chữ số
        static void Ex15()
        {
            Title("15. Thong ke ky tu va chu so");
            string path = SampleFile();
            string[] lines = File.ReadAllLines(path);

            // (a) Mảng chữ nhật: hàng 0 = chữ cái, hàng 1 = chữ số; cột = mã ASCII
            int[,] freq = new int[2, 128];
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    if (c >= 128) continue;
                    if (char.IsLetter(c)) freq[0, c]++;
                    else if (char.IsDigit(c)) freq[1, c]++;
                }
            }

            Console.WriteLine("(a) Tan suat (mang chu nhat):");
            for (int r = 0; r < 2; r++)
            {
                Console.WriteLine(r == 0 ? "Chu cai:" : "Chu so:");
                for (int code = 0; code < 128; code++)
                    if (freq[r, code] > 0)
                        Console.WriteLine($"  '{(char)code}' : {freq[r, code]}");
            }

            // (b) Mảng răng cưa: positions[code] = danh sách (dòng, cột) xuất hiện
            // Dùng freq để cấp phát đúng kích thước từng hàng.
            (int line, int col)[][] positions = new (int, int)[128][];
            for (int code = 0; code < 128; code++)
            {
                int total = freq[0, code] + freq[1, code];
                if (total > 0) positions[code] = new (int, int)[total];
            }

            int[] filled = new int[128];
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    char c = lines[i][j];
                    if (c >= 128 || !char.IsLetterOrDigit(c)) continue;
                    positions[c][filled[c]++] = (i + 1, j + 1); // dòng, cột tính từ 1
                }
            }

            Console.WriteLine("\n(b) Vi tri xuat hien (mang rang cua) - dong,cot:");
            for (int code = 0; code < 128; code++)
            {
                if (positions[code] == null) continue;
                string list = string.Join(" ", positions[code].Select(p => $"({p.line},{p.col})"));
                Console.WriteLine($"  '{(char)code}' [{positions[code].Length} lan]: {list}");
            }
        }
    }

}

