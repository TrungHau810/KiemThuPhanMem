//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GiaiPhuongTrinhBac2_53_57_HauNgoc
//{
//    public class PTBac2_53_57_HauNgoc
//    {
//        double a_53_57_HauNgoc, b_53_57_HauNgoc, c_53_57_HauNgoc;

//        public PTBac2_53_57_HauNgoc(double a_53_57_HauNgoc, double b_53_57_HauNgoc, double c_53_57_HauNgoc)
//        {
//            this.a_53_57_HauNgoc = a_53_57_HauNgoc;
//            this.b_53_57_HauNgoc = b_53_57_HauNgoc;
//            this.c_53_57_HauNgoc = c_53_57_HauNgoc;
//        }

//        public string Solve_53_57_HauNgoc()
//        {
//            if (this.a_53_57_HauNgoc == 0)
//            {
//                if (this.b_53_57_HauNgoc == 0)
//                    return (this.c_53_57_HauNgoc == 0) ? "Phương trình có vô số nghiệm" : "Phương trình vô nghiệm";

//                double x_53_57_HauNgoc = -this.c_53_57_HauNgoc / this.b_53_57_HauNgoc;
//                return $"x = {x_53_57_HauNgoc.ToString("0.##")}";
//            }

//            double delta_53_57_HauNgoc = Math.Pow(this.b_53_57_HauNgoc, 2) - 4 * this.a_53_57_HauNgoc * this.c_53_57_HauNgoc;

//            if (delta_53_57_HauNgoc < 0)
//                return "Phương trình vô nghiệm";

//            if (delta_53_57_HauNgoc == 0)
//            {
//                double x_53_57_HauNgoc = -this.b_53_57_HauNgoc / (2 * this.a_53_57_HauNgoc);
//                return $"Nghiệm kép x = {x_53_57_HauNgoc.ToString("0.##")}";
//            }

//            double x1_53_57_HauNgoc = (-this.b_53_57_HauNgoc + Math.Sqrt(delta_53_57_HauNgoc)) / (2 * this.a_53_57_HauNgoc);
//            double x2_53_57_HauNgoc = (-this.b_53_57_HauNgoc - Math.Sqrt(delta_53_57_HauNgoc)) / (2 * this.a_53_57_HauNgoc);
//            return $"x1 = {x1_53_57_HauNgoc.ToString("0.##")}, x2 = {x2_53_57_HauNgoc.ToString("0.##")}";
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinhBac2_53_57_HauNgoc
{
    public class PTBac2_53_57_HauNgoc
    {
        double a_53_57_HauNgoc, b_53_57_HauNgoc, c_53_57_HauNgoc;
        public PTBac2_53_57_HauNgoc(double a_53_57_HauNgoc, double b_53_57_HauNgoc, double c_53_57_HauNgoc)
        {
            this.a_53_57_HauNgoc = a_53_57_HauNgoc;
            this.b_53_57_HauNgoc = b_53_57_HauNgoc;
            this.c_53_57_HauNgoc = c_53_57_HauNgoc;
        }
        public string Solve_53_57_HauNgoc()
        {
            if (this.a_53_57_HauNgoc == 0)
            {
                // bx + c = 0
                if (this.b_53_57_HauNgoc == 0)
                    return (this.c_53_57_HauNgoc == 0) ? "Phương trình có vô số nghiệm" : "Phương trình vô nghiệm";

                // G (General Format): Nếu số là số nguyên, nó sẽ k hiển thị dấu phẩy (2 thay vì 2.00)
                // Nếu x là số thập phân sẽ tự động làm tròn 2 chữ số thập phân (như 2.53)
                double x_53_57_HauNgoc = (-this.c_53_57_HauNgoc / this.b_53_57_HauNgoc);
                return $"x = {(x_53_57_HauNgoc % 1 == 0 ? x_53_57_HauNgoc.ToString("G") : x_53_57_HauNgoc.ToString("0.##"))}";
            }
            // Tính delta = b^2 - 4ac
            double delta_53_57_HauNgoc = (this.b_53_57_HauNgoc * this.b_53_57_HauNgoc) - (4 * this.a_53_57_HauNgoc * this.c_53_57_HauNgoc);
            if (delta_53_57_HauNgoc < 0)
                return "Phương trình vô nghiệm";

            else if (delta_53_57_HauNgoc == 0)
            {
                double x_53_57_HauNgoc = -this.b_53_57_HauNgoc / (2 * this.a_53_57_HauNgoc);
                return $"Nghiệm kép x = {(x_53_57_HauNgoc % 1 == 0 ? x_53_57_HauNgoc.ToString("G") : x_53_57_HauNgoc.ToString("0.##"))}";
            }
            // delta > 0
            else
            {
                double x1_53_57_HauNgoc = (-this.b_53_57_HauNgoc + Math.Sqrt(delta_53_57_HauNgoc)) / (2 * this.a_53_57_HauNgoc);
                double x2_53_57_HauNgoc = (-this.b_53_57_HauNgoc - Math.Sqrt(delta_53_57_HauNgoc)) / (2 * this.a_53_57_HauNgoc);
                // Chỉnh format x1 và x2 
                return $"x1 = {(x1_53_57_HauNgoc % 1 == 0 ? x1_53_57_HauNgoc.ToString("G") : x1_53_57_HauNgoc.ToString("0.##"))}, " +
                     $"x2 = {(x2_53_57_HauNgoc % 1 == 0 ? x2_53_57_HauNgoc.ToString("G") : x2_53_57_HauNgoc.ToString("0.##"))}";
            }
        }
    }
}