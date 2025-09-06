using System;

namespace Ep_Kieu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ép kiểu (Type casting / Type conversion):
            - Là chuyển đổi từ kiểu dữ liệu này sang kiểu dữ liệu khác
            - Có 2 dạng ép kiểu:
              + Ép kiểu ngầm định (Implicit casting): Tự động chuyển đổi khi không mất dữ liệu
                Ví dụ: int -> float, char -> int
              + Ép kiểu tường minh (Explicit casting): Chuyển đổi thủ công khi có thể mất dữ liệu
                Ví dụ: float -> int, double -> float
            */
            // Ép kiểu ngầm định
            int num_a = 10;
            float num_b = num_a; // Tự động chuyển int sang float
            Console.WriteLine("Ép kiểu ngầm định:");
            Console.WriteLine("Giá trị của num_a (int): {0}", num_a);
            Console.WriteLine("Giá trị của num_b (float): {0}", num_b);
            // Ép kiểu tường minh
            float num_c = 9.78f;
            int num_d = (int)num_c; // Chuyển float sang int, mất phần thập phân
            Console.WriteLine("\nÉp kiểu tường minh:");
            Console.WriteLine("Giá trị của num_c (float): {0}", num_c);
            Console.WriteLine("Giá trị của num_d (int): {0}", num_d);
            // Sử dụng Convert class để ép kiểu
            string str_num = "123";
            int num_e = Convert.ToInt32(str_num); // Chuyển string sang int
            Console.WriteLine("\nSử dụng Convert class:");
            Console.WriteLine("Giá trị của str_num (string): {0}", str_num);
            Console.WriteLine("Giá trị của num_e (int): {0}", num_e);

            // Sử dụng Parse và TryParse để chuyển đổi kiểu
            string input = "456";
            int value = int.Parse(input);        // ném lỗi nếu chuỗi không hợp lệ
            int value2;
            bool ok = int.TryParse(input, out value2); // an toàn, trả về true/false

            // Boxing và Unboxing
            int x = 42;
            object obj = x;         // boxing (value type → object)
            int y = (int)obj;       // unboxing (object → value type)
            Console.WriteLine(y);

            // Sử dụng 'as' và 'is' để kiểm tra và chuyển đổi kiểu an toàn
            object o = "hello";
            string s1 = o as string;       // an toàn, s1 = "hello"
            if (o is string s2) { /* s2 usable */ }


        }
    }
}