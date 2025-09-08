using System;

namespace ObjectType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kiểu dữ liệu object:
            - Là kiểu dữ liệu cơ bản nhất trong C#
            - Mọi kiểu dữ liệu khác đều kế thừa từ object
            - Có thể lưu trữ bất kỳ kiểu dữ liệu nào (số, chuỗi, đối tượng, v.v.)
            - Khi lấy giá trị từ object, cần ép kiểu (casting) về kiểu dữ liệu ban đầu
            - Ví dụ sử dụng:
            */
            object obj1 = 42; // Lưu trữ số nguyên
            object obj2 = "Hello, World!"; // Lưu trữ chuỗi
            object obj3 = 3.14; // Lưu trữ số thực
            // Ép kiểu về int
            int number = (int)obj1;
            Console.WriteLine("Số nguyên: " + number);
            // Ép kiểu về string
            string message = (string)obj2;
            Console.WriteLine("Chuỗi: " + message);
            // Ép kiểu về double
            double pi = (double)obj3;
            Console.WriteLine("Số thực: " + pi);
            // Sử dụng object để lưu trữ các loại dữ liệu khác nhau trong mảng
            object[] mixedArray = new object[] { 1, "Two", 3.0, true };
            foreach (var item in mixedArray)
            {
                Console.WriteLine("Giá trị: " + item + ", Kiểu: " + item.GetType());
            }

            object _name = "Nguyen Van A";
            _name.Equals("Nguyen Van A"); // So sánh đối tượng với một đối tượng khác
            _name.GetHashCode(); // Trả về mã băm của đối tượng
            _name.GetType(); // Trả về kiểu dữ liệu của đối tượng
            _name.ToString(); // Trả về chuỗi biểu diễn của đối tượng
        }
    }
}
