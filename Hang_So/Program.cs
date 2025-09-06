using System;

namespace Hang_So
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hằng số (Constant):
            - Là dữ liệu không thể thay đổi trong suốt quá trình thực thi chương trình
            - Cú pháp: const <Kiểu dữ liệu> <Tên hằng> = <Giá trị>;
                     Ví dụ: const float PI = 3.14f;
            - Quy tắc đặt tên hằng:
              + Giống như quy tắc đặt tên biến
              + Thường đặt tên bằng chữ in hoa, các từ cách nhau bởi dấu gạch dưới (_)
            */
            const float PI = 3.14f;
            const int SO_NGAY_TRONG_TUAN = 7;
            Console.WriteLine("Giá trị của hằng số PI: {0}", PI);
            Console.WriteLine("Số ngày trong tuần: {0}", SO_NGAY_TRONG_TUAN);
        }
    }
}