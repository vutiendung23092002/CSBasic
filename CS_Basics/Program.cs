using System;

namespace Nhap_Xuat_Co_Ban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10; // Khai báo biến a kiểu int và gán giá trị 10

            #region Console.Write()
            //Console.Write("Hello, I am Vu Tien Dung");
            //Console.Write(10);
            //Console.Write(10.9f);
            //Console.Write(true);
            //Console.Write("a = " + a); // In ra giá trị của biến a
            //Console.Write("a = {0}", a); // In ra giá trị của biến a
            //Console.Write($"a = {a}"); // In ra giá trị của biến a
            // Lưu ý: Muốn in ra giá trị của biến thì phải dùng + hoặc {0} hoặc $ để nó hiểu là biến
            // Muốn in ra chuỗi thì phải dùng dấu "" để nó hiểu là chuỗi
            // Muốn in ra ký tự đặc biệt thì phải dùng \ trước ký tự đặc biệt đó
            // Ví dụ: \n (xuống dòng), \t (tab), \\ (dấu \), \" (dấu ")
            // Muốn in ra dấu { hoặc } thì phải dùng {{ hoặc }} để nó hiểu là dấu { hoặc }
            // Muốn in ra dấu $ thì phải dùng $$ để nó hiểu là dấu $
            // Muốn in ra dấu @ thì phải dùng @@ để nó hiểu là dấu @
            // Muốn in ra dấu % thì phải dùng %% để nó hiểu là dấu %
            // ...
            // Muốn comment nhiều dòng thì bôi đen đoạn code rồi nhấn Ctrl K C
            // Muốn bỏ comment nhiều dòng thì bôi đen đoạn code rồi nhấn Ctrl K U
            // Dùng {} để định dạng chuỗi
            //Console.Write("a = {0}, b = {1}, c = {2}", 10, 20, 30); // In ra a = 10, b = 20, c = 30. Giá trị 0 là giá trị của biến a, Giá trị 1 là giá trị của biến b, Giá trị 2 là giá trị của biến c
            #endregion

            #region Console.WriteLine()
            //Console.Write("Hello, I am Vu Tien Dung\n"); // Sử dung ký tự đặc biệt \n để xuống dòng
            //Console.WriteLine(10); // Tự động xuống dòng
            //Console.Write(Environment.NewLine); //Dùng lệnh này để xuống dòng tương tự như \n, ít sử dụng hơn
            //Console.WriteLine(10.9f); // Tự động xuống dòng

            //Console.ReadLine(); // Dừng lại đợi người dùng nhập dữ liệu rồi nhấn Enter
            #endregion

            #region Console.WriteLine() + Console.ReadLine()
            //Console.Write("Enter your name: " + Console.Read()); // Dừng lại đợi người dùng nhập dữ liệu rồi nhấn Enter, chỉ lấy ký tự đầu tiên mà người dùng nhập Output: mã ASCII của ký tự đó
            //Console.Write("Enter your name: " + Console.ReadLine()); // Dừng lại đợi người dùng nhập dữ liệu rồi nhấn Enter, lấy toàn bộ chuỗi mà người dùng nhập Output: chuỗi mà người dùng nhập
            //Console.ReadKey();
            #endregion

            #region Console.ReadKey()
            //Console.Write("Press any key to continue... ");
            //Console.ReadKey(); // Dừng lại đợi người dùng nhấn một phím bất kỳ rồi mới tiếp tục chạy chương trình, k truyền tham số thì mặc định là false
            //Console.ReadKey(false); // Dừng lại đợi người dùng nhấn một phím bất kỳ rồi mới tiếp tục chạy chương trình, hiển thị phím mà người dùng nhấn
            //Console.ReadKey(true); // Dừng lại đợi người dùng nhấn một phím bất kỳ rồi mới tiếp tục chạy chương trình, không hiển thị phím mà người dùng nhấn
            #endregion

            Console.WriteLine("Hello dev!!!!");

            Console.Write("Enter your name: ");
            Console.WriteLine("Your name: " + Console.ReadLine());

            Console.Write("Enter your age: ");
            Console.WriteLine("Your age: " + Console.ReadLine());

            Console.ReadKey();
        }
    }
}