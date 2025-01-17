using Newtonsoft.Json;
public class CircleInfo
{
    public double DienTich { get; set; }
    public double ChuVi { get; set; }
    public double DuongKinh { get; set; }
}

public class Circle
{
    public string GetCircleInfo(double r)
    {
        if (r <= 0.0)
        {
            return JsonConvert.SerializeObject(new { error = "Bán kính phải lớn hơn 0!" });
        }

        double dienTich = Math.PI * r * r;
        double chuVi = 2 * Math.PI * r;
        double duongKinh = 2 * r;

        CircleInfo circleInfo = new CircleInfo
        {
            DienTich = dienTich,
            ChuVi = chuVi,
            DuongKinh = duongKinh
        };

        return JsonConvert.SerializeObject(circleInfo);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        double r; // Bán kính hình tròn

        Console.WriteLine("Nhập bán kính:");
        while (true)
        {

            string input = Console.ReadLine();

            try
            {
                r = Convert.ToDouble(input);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("…");
            }
        }

        string result = circle.GetCircleInfo(r);
        Console.WriteLine(result);
    }
}