using System;
using System.Linq;
using System.Collections.Generic;

namespace BaiTapC_Sharp_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CHƯƠNG TRÌNH GIẢI 20 BÀI TẬP C# - HÀM ===");

            // --- Phần 1: Bài tập có hướng dẫn ---

            // Bài 1
            Console.WriteLine($"\n--- Bài 1: Tính tổng hai số nguyên ---");
            Console.WriteLine($"Tổng của 5 và 10 là: {TinhTong(5, 10)}");

            // Bài 2
            Console.WriteLine($"\n--- Bài 2: Kiểm tra số chẵn lẻ ---");
            Console.WriteLine($"Số 4 là chẵn? {KiemTraChan(4)}");
            Console.WriteLine($"Số 7 là chẵn? {KiemTraChan(7)}");

            // Bài 3
            Console.WriteLine($"\n--- Bài 3: Tìm số lớn nhất trong ba số ---");
            Console.WriteLine($"Số lớn nhất trong 3, 9, 5 là: {TimMax(3, 9, 5)}");

            // Bài 4
            Console.WriteLine($"\n--- Bài 4: Tính giai thừa của một số ---");
            Console.WriteLine($"5! = {TinhGiaiThua(5)}");

            // Bài 5
            Console.WriteLine($"\n--- Bài 5: Đảo ngược chuỗi ký tự ---");
            Console.WriteLine($"Đảo ngược 'Lập trình': {DaoNguocChuoi("Lập trình")}");

            // --- Phần 2: Bài tập có kết quả mẫu tham chiếu ---

            // Bài 6
            Console.WriteLine($"\n--- Bài 6: Kiểm tra số nguyên tố ---");
            Console.WriteLine($"Input: 7 -> Output: {KiemTraNguyenTo(7)}");
            Console.WriteLine($"Input: 10 -> Output: {KiemTraNguyenTo(10)}");

            // Bài 7
            Console.WriteLine($"\n--- Bài 7: In dãy Fibonacci ---");
            Console.Write("Input: 6 -> Output: ");
            InFibonacci(6);
            Console.WriteLine();

            // Bài 8
            Console.WriteLine($"\n--- Bài 8: Đếm số lượng nguyên âm trong chuỗi ---");
            Console.WriteLine($"Input: \"Hello World\" -> Output: {DemNguyenAm("Hello World")}");

            // Bài 9
            Console.WriteLine($"\n--- Bài 9: Tính lũy thừa ---");
            Console.WriteLine($"Input: x = 2, y = 3 -> Output: {TinhLuyThua(2, 3)}");

            // Bài 10
            Console.WriteLine($"\n--- Bài 10: Tính điểm trung bình của mảng ---");
            int[] arr10 = { 4, 5, 6, 7 };
            Console.WriteLine($"Input: [4, 5, 6, 7] -> Output: {TinhTrungBinh(arr10)}");

            // Bài 11
            Console.WriteLine($"\n--- Bài 11: Kiểm tra chuỗi đối xứng (Palindrome) ---");
            Console.WriteLine($"Input: \"radar\" -> Output: {KiemTraDoiXung("radar")}");
            Console.WriteLine($"Input: \"hello\" -> Output: {KiemTraDoiXung("hello")}");

            // Bài 12
            Console.WriteLine($"\n--- Bài 12: Chuyển đổi nhiệt độ ---");
            Console.WriteLine($"Input: 25 độ C -> Output: {CelsiusToFahrenheit(25)} độ F");

            // Bài 13
            Console.WriteLine($"\n--- Bài 13: Tìm giá trị nhỏ nhất trong mảng ---");
            int[] arr13 = { 10, 5, 8, 2, 9 };
            Console.WriteLine($"Input: [10, 5, 8, 2, 9] -> Output: {TimMin(arr13)}");

            // Bài 14
            Console.WriteLine($"\n--- Bài 14: Tính tổng các chữ số của một số nguyên ---");
            Console.WriteLine($"Input: 1234 -> Output: {TongCacChuSo(1234)}");

            // Bài 15
            Console.WriteLine($"\n--- Bài 15: Sắp xếp mảng tăng dần ---");
            int[] arr15 = { 3, 1, 4, 2 };
            Console.Write("Input: [3, 1, 4, 2] -> Output: ");
            SapXepMang(arr15);

            // Bài 16
            Console.WriteLine($"\n--- Bài 16: Xóa ký tự trùng lặp ---");
            Console.WriteLine($"Input: \"programming\" -> Output: \"{XoaTrungLap("programming")}\"");

            // Bài 17
            Console.WriteLine($"\n--- Bài 17: Tìm ước chung lớn nhất (UCLN) ---");
            Console.WriteLine($"Input: a = 12, b = 18 -> Output: {UCLN(12, 18)}");

            // Bài 18
            Console.WriteLine($"\n--- Bài 18: Chuyển đổi hệ thập phân sang nhị phân ---");
            Console.WriteLine($"Input: 10 -> Output: \"{DecimalToBinary(10)}\"");

            // Bài 19
            Console.WriteLine($"\n--- Bài 19: Kiểm tra năm nhuận ---");
            Console.WriteLine($"Input: 2024 -> Output: {KiemTraNamNhuan(2024)}");
            Console.WriteLine($"Input: 2023 -> Output: {KiemTraNamNhuan(2023)}");

            // Bài 20
            Console.WriteLine($"\n--- Bài 20: Đếm số từ trong câu ---");
            Console.WriteLine($"Input: \"Học lập trình C# rất thú vị\" -> Output: {DemSoTu("Học lập trình C# rất thú vị")}");

            Console.WriteLine("\n=== HOÀN THÀNH TẤT CẢ BÀI TẬP ===");
        }

        // ================= PHẦN 1: HÀM BÀI 1 - BÀI 5 =================

        // Bài 1
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }

        // Bài 2
        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        // Bài 3
        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        // Bài 4
        public static long TinhGiaiThua(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }

        // Bài 5
        public static string DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // ================= PHẦN 2: HÀM BÀI 6 - BÀI 20 =================

        // Bài 6: Kiểm tra số nguyên tố
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Bài 7: In dãy Fibonacci
        public static void InFibonacci(int n)
        {
            if (n <= 0) return;
            long a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                long temp = a;
                a = b;
                b = temp + b;
            }
        }

        // Bài 8: Đếm số lượng nguyên âm trong chuỗi
        public static int DemNguyenAm(string s)
        {
            char[] nguyenAm = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;
            foreach (char c in s)
            {
                if (Array.Exists(nguyenAm, element => element == c))
                {
                    count++;
                }
            }
            return count;
        }

        // Bài 9: Tính lũy thừa
        public static double TinhLuyThua(double x, int y)
        {
            double result = 1;
            bool isNegative = y < 0;
            int power = Math.Abs(y);
            for (int i = 0; i < power; i++)
            {
                result *= x;
            }
            return isNegative ? 1 / result : result;
        }

        // Bài 10: Tính điểm trung bình của mảng
        public static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            double sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum / arr.Length;
        }

        // Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
        public static bool KiemTraDoiXung(string s)
        {
            string daoNguoc = DaoNguocChuoi(s);
            return s.Equals(daoNguoc, StringComparison.OrdinalIgnoreCase);
        }

        // Bài 12: Chuyển đổi nhiệt độ
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9.0 / 5.0) + 32;
        }

        // Bài 13: Tìm giá trị nhỏ nhất trong mảng
        public static int TimMin(int[] arr)
        {
            if (arr == null || arr.Length == 0) throw new ArgumentException("Mảng rỗng");
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
            }
            return min;
        }

        // Bài 14: Tính tổng các chữ số của một số nguyên
        public static int TongCacChuSo(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        // Bài 15: Sắp xếp mảng tăng dần
        public static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        // Bài 16: Xóa ký tự trùng lặp
        public static string XoaTrungLap(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }

        // Bài 17: Tìm ước chung lớn nhất (UCLN)
        public static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        // Bài 18: Chuyển đổi hệ thập phân sang nhị phân
        public static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            return binary;
        }

        // Bài 19: Kiểm tra năm nhuận
        public static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Bài 20: Đếm số từ trong câu
        public static int DemSoTu(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
