using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Câu lệnh điều kiện if...else:
            - Dùng để thực hiện các khối mã khác nhau dựa trên điều kiện đúng/sai
            - Cú pháp:
              if (điều_kiện) {
                  // khối mã nếu điều kiện đúng
              } else {
                  // khối mã nếu điều kiện sai
              }
            - Có thể có nhiều điều kiện bằng cách sử dụng else if
            */
            int number = 10;
            // Sử dụng if...else để kiểm tra số chẵn/lẻ
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} là số chẵn.", number);
            }
            else
            {
                Console.WriteLine("{0} là số lẻ.", number);
            }
            // Sử dụng else if để kiểm tra nhiều điều kiện
            int score = 85;
            if (score >= 90)
            {
                Console.WriteLine("Học sinh đạt loại A.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Học sinh đạt loại B.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Học sinh đạt loại C.");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Học sinh đạt loại D.");
            }
            else
            {
                Console.WriteLine("Học sinh rớt.");
            }
            // Sử dụng toán tử điều kiện ba ngôi (ternary operator) để viết gọn if...else
            int age = 20;
            string eligibility = (age >= 18) ? "đủ tuổi" : "chưa đủ tuổi";
            Console.WriteLine("Bạn {0} bầu cử.", eligibility);
        }
    }
}