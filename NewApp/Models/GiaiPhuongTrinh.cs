using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class GiaiPhuongTrinh
    {
        public string PhuongTrinhBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phuong trinh vo so nghiem";
                }
                else
                {
                    return "Phuong trinh vo nghiem";
                }
            }
            else
            {
                return $"Phuong trinh co nghiem la: {-b/a}";
            }
        }
        public string PhuongTrinhBac2(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);
            if (a == 0)
            {
                return $"Phuong trinh co nghiem duy nhat la {-c / b}";
            }
            if (delta < 0)
            {
                return 0.0.ToString();
            }
            else if (delta == 0)
            {
                return (-b / (2 * a)).ToString();
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                string value1 = $"Nghiem thu nhat x1 = {x1}";
                string value2 = $"Nghiem thu nhat x1 = {x2}";
                return value1 + "\n" + value2;
            }

        }
    }
}