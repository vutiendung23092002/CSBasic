using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Câu lệnh switch...case:
            - Dùng để chọn một trong nhiều khối mã dựa trên giá trị của một biến
            - Cú pháp:
              switch (biến) {
                  case giá_trị_1:
                      // khối mã nếu biến == giá_trị_1
                      break;
                  case giá_trị_2:
                      // khối mã nếu biến == giá_trị_2
                      break;
                  ...
                  default:
                      // khối mã nếu không khớp với bất kỳ case nào
                      break;
              }
            - Mỗi case nên kết thúc bằng từ khóa break để tránh rơi vào các case tiếp theo
            - Có thể có một case default tùy chọn để xử lý các trường hợp không khớp
            */
            int day = 3;
            string dayName;
            // Sử dụng switch...case để xác định tên ngày trong tuần
            switch (day)
            {
                case 1:
                    dayName = "Chủ Nhật";
                    break;
                case 2:
                    dayName = "Thứ Hai";
                    break;
                case 3:
                    dayName = "Thứ Ba";
                    break;
                case 4:
                    dayName = "Thứ Tư";
                    break;
                case 5:
                    dayName = "Thứ Năm";
                    break;
                case 6:
                    dayName = "Thứ Sáu";
                    break;
                case 7:
                    dayName = "Thứ Bảy";
                    break;
                default:
                    dayName = "Ngày không hợp lệ";
                    break;
            }
            Console.WriteLine("Ngày {0} là: {1}", day, dayName);
            // Ví dụ khác: Sử dụng switch với chuỗi
            string fruit = "Táo";
            string color;
            switch (fruit)
            {
                case "Táo":
                    color = "Đỏ hoặc xanh";
                    break;
                case "Chuối":
                    color = "Vàng";
                    break;
                case "Cam":
                    color = "Cam";
                    break;
                default:
                    color = "Không rõ màu sắc";
                    break;
            }
            Console.WriteLine("Quả {0} có màu: {1}", fruit, color);
        }
    }
}