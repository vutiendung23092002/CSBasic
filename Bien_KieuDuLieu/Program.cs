using System;

namespace Bien_KieuDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Biến
            /*
            - Là dữ liệu có thể thay đổi
            - Là tên gọi tham chiếu đến một vùng nhớ nào đó trong bộ nhớ
            - Lưu trữ và tái sử dụng
            - Thao tác với bộ nhớ một cách dễ dàng
            - <Kiểu dữ liệu> <Tên biến>
                            int Kieu_SoNguyen = 10;
                            float Kieu_SoThuc = 6.9f;
                            string Kieu_Chuoi = "Hello dev!!";
                            bool Kieu_Logic = true;
                            char Kieu_KyTu = 'K';
            */
            int num_a = 10;
            int num_b = 15;
            int num_c = num_a + num_b;
            Console.WriteLine("a + b = c : {0} + {1} = {2}", num_a, num_b, num_c);

            /*
            * Quy tắc đặt tên biến
            - Chuỗi ký tự liên kết (không có khoảng trắng), không chứa ký tự đặc biệt, không đặt bằng tiếng Việt, không bắt đầu bằng số
            - Tên biến không được trùng nhau
            - Tên biến không được trùng với các từ khóa trong C# (ví dụ float, int, case, break,...)
            * Quy tắc chung của các Dev:
            - Quy tắc lạc đà: Viết thường từ đầu tiên và viết hoa chữ cái đầu của các từ tiếp theo (VD: numA, numB,...) thường dùng cho private và protected
            - Quy tắc Pascal: Viết hoa chữ cái đầu tiên của các từ (Thường được dùng cho các Th còn lại)
            Một số lưu ý:  - Đặt tên ngắn gọn, dễ hiểu, thể hiện rõ mục đích của biến
                           - Có phân biệt chữ hoa chữ thường (VD: biến A và a là 2 biết khác nhau)
            */

            /*
            Kiểu dữ liệu (Data type):
            - Là cách ngôn ngữ lập trình định nghĩa dạng và kích thước bộ nhớ
              dùng để lưu trữ giá trị. Nó cũng cho trình biên dịch biết
              những phép toán nào hợp lệ trên dữ liệu đó.

            - Giúp:
              + Trình biên dịch biết cần cấp bao nhiêu bộ nhớ
              + Xác định giá trị hợp lệ và thao tác được phép

            - Chia làm 2 nhóm lớn:
              1. Kiểu dữ liệu có sẵn (Built-in / Primitive types):
                 int, float, double, bool, char, decimal, ...
                 Ví dụ: int a = 10;

              2. Kiểu dữ liệu do người dùng định nghĩa (User-defined):
                 class, struct, enum
                 (trong C#, string thực ra là một class do .NET Framework cung cấp,
                  vẫn thường được xem như "built-in" nhưng bản chất là kiểu tham chiếu)

            - Ngoài ra có thể phân theo:
              + Kiểu giá trị (Value types): int, float, bool, struct, enum, char (Không thể để null, nếu gán null phải khai báo int? a = null)
              + Kiểu tham chiếu (Reference types): string, object, class, array (Có thể null)
            */

            #region Ví dụ kiểu dữ liệu

            // --- Kiểu số nguyên ---
            byte BienByte = 10;   // 8 bit, 0..255
            short BienShort = 10; // 16 bit, -32,768..32,767
            int BienInt = 10;     // 32 bit, -2,147,483,648..2,147,483,647
            long BienLong = 10;   // 64 bit, rất lớn

            BienLong = BienByte;  // OK: gán từ kiểu nhỏ sang kiểu lớn (implicit widening) nhưng k thể gán lớn cho nhỏ

            // --- Kiểu số thực ---
            float BienFloat = 10.6f;    // 32 bit, hậu tố f hoặc F bắt buộc
            double BienDouble = 10.6;   // 64 bit, mặc định số thực là double
            decimal BienDecimal = 10.6m; // 128 bit, độ chính xác cao cho tài chính, hậu tố m hoặc M

            // --- Kiểu ký tự và chuỗi ---
            char BienChar = 'a';       // ký tự Unicode duy nhất, dùng nháy đơn ''
            string BienString = "Hello dev"; // chuỗi ký tự, dùng nháy kép ""

            #endregion

        }
    }
}