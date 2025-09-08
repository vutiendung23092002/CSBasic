using System;
using System.Linq.Expressions;

namespace Caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tạo một ứng dụng máy tính đơn giản Cộng , Trừ, Nhân, Chia 2 số
            */
            double num1, num2, result; // Khai báo biến num1, num2, result kiểu double

            Console.WriteLine("Hello, Wellcome to Caculator!");

            Console.WriteLine("Enter number 1st: ");
            // Kiểm tra nhập liệu hợp lệ cho num1
            while (!double.TryParse(Console.ReadLine(), out num1)) {
                Console.WriteLine("Invalid input. Please enter a valid number for number 1st: ");
            }

            Console.WriteLine("Choose operator (+, -, *, /): ");
            string? operatorCaculator; // Khai báo biến operatorCaculator kiểu string
            // Kiểm tra nhập liệu hợp lệ cho operatorCaculator
            while (true) {
                operatorCaculator = Console.ReadLine();
                if (operatorCaculator == "+" || operatorCaculator == "-" || operatorCaculator == "*" || operatorCaculator == "/") {
                    break;
                } else {
                    Console.WriteLine("Invalid operator. Please choose a valid operator (+, -, *, /): ");
                }
            }

            Console.WriteLine("Enter number 2nd: ");
            // Kiểm tra nhập liệu hợp lệ cho num2
            while (!double.TryParse(Console.ReadLine(), out num2)) {
                Console.WriteLine("Invalid input. Please enter a valid number for number 2nd: ");
            }

            // Thực hiện phép tính dựa trên toán tử đã chọn
            switch (operatorCaculator) {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "/":
                    // Kiểm tra chia cho 0
                    while (true) {
                        if (num2 == 0) {
                            Console.WriteLine("Cannot divide by zero. Please enter a valid number for number 2nd: ");
                            while (!double.TryParse(Console.ReadLine(), out num2)) {
                                Console.WriteLine("Invalid input. Please enter a valid number for number 2nd: ");
                            }
                        } else {
                            break;
                        }
                    }
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Operator is not valid!");
                    break;
            }
            Console.ReadKey();

        }
    }
}