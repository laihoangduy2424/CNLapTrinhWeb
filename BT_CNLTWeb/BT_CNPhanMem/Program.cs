using System;
using System.Text.Json;

namespace CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            while (true)
            {
                Console.Write("Nhap ban kinh hinh tron (r > 0): ");
                string input = Console.ReadLine();

                // Kiểm tra
                if (double.TryParse(input, out radius) && radius > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le. Nhap lai!");
                }
            }

            string result = CalculateCircleProperties(radius);
            Console.WriteLine("Ket qua: " + result);
        }

        static string CalculateCircleProperties(double r)
        {
            double dienTich = Math.PI * r * r;
            double chuVi = 2 * Math.PI * r;
            double duongKinh = 2 * r;

            // Đóng gói JSON
            var result = new
            {
                dien_tich = dienTich,
                chu_vi = chuVi,
                duong_kinh = duongKinh
            };

            // Trả về JSON
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(result, options);
        }
    }
}
