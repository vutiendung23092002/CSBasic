using System;

namespace ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Toán tử (Operator):
            - Là ký hiệu biểu diễn cho một thao tác nào đó
            - Toán tử sẽ thao tác trên các toán hạng (Operand)
            - Có nhiều loại toán tử khác nhau:
              + Toán tử số học (Arithmetic): +, -, *, /, %, ++, --
              + Toán tử gán (Assignment): =, +=, -=, *=, /=
              + Toán tử so sánh (Comparison): ==, !=, >, <, >=, <=
              + Toán tử logic (Logical): &&, ||, !
              + Toán tử khác: sizeof, typeof, ...
            */
            // Toán tử số học
            int num_a = 10;
            int num_b = 3;
            Console.WriteLine("Toán tử số học:");
            Console.WriteLine("a + b = {0}", num_a + num_b); // Phép cộng
            Console.WriteLine("a - b = {0}", num_a - num_b); // Phép trừ
            Console.WriteLine("a * b = {0}", num_a * num_b); // Phép nhân
            Console.WriteLine("a / b = {0}", num_a / num_b); // Phép chia lấy phần nguyên
            Console.WriteLine("a % b = {0}", num_a % num_b); // Phép chia lấy phần dư
            // Toán tử gán
            Console.WriteLine("\nToán tử gán:");
            int num_c = 5; // Gán giá trị 5 cho biến c
            Console.WriteLine("Giá trị ban đầu của c: {0}", num_c);
            num_c += 3; // Tương đương num_c = num_c + 3
            Console.WriteLine("Giá trị của c sau phép cộng: {0}", num_c);
            num_c -= 2; // Tương đương num_c = num_c - 2
            Console.WriteLine("Giá trị của c sau phép trừ: {0}", num_c);
            num_c *= 4; // Tương đương num_c = num_c * 4
            Console.WriteLine("Giá trị của c sau phép nhân: {0}", num_c);

            Console.WriteLine(num_a++); // Tăng num_a lên 1 (sau khi in ra mới tăng)
            Console.WriteLine(++num_a); // Tăng num_a lên 1 (trước khi in ra đã tăng)
        }
    }
}
