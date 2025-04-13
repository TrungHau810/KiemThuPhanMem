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

        // Hàm dùng để fommat lại kết quả nghiệm xuất ra màn hình
        private string FormatNumber_53_57_HauNgoc(double number_53_57_HauNgoc)
        {
            // G (General Format): Nếu số là số nguyên, nó sẽ k hiển thị dấu phẩy (2 thay vì 2.00)
            // Nếu x là số thập phân sẽ tự động làm tròn 2 chữ số thập phân (như 2.53)
            // Nếu là 1 chữ số thập phân như 0.5000 -> 0.5
            return (number_53_57_HauNgoc % 1 == 0) ? number_53_57_HauNgoc.ToString("G") : number_53_57_HauNgoc.ToString("0.##");
        }

        public string Solve_53_57_HauNgoc()
        {
            if (this.a_53_57_HauNgoc == 0)
            {
                // a = 0 -> Trở thành phương trình bậc 1: bx + c = 0
                // Nếu b = 0
                if (this.b_53_57_HauNgoc == 0)
                    // Nếu c = 0 -> Phương trình có vô số nghiệm, ngược lại thì phương trình vô nghiệm
                    return (this.c_53_57_HauNgoc == 0) ? "Phuong trinh co vo so nghiem" : "Phuong trinh vo nghiem";
                // Nếu b khác 0
                // Tính nghiệm x của phương trình bậc 1 bằng công thức -c/b
                double x_53_57_HauNgoc = (-this.c_53_57_HauNgoc / this.b_53_57_HauNgoc);
                // Trả về kết quả nghiệm x = ...
                return $"x = {FormatNumber_53_57_HauNgoc(x_53_57_HauNgoc)}";
            }
            // Tính delta = b^2 - 4ac
            double delta_53_57_HauNgoc = (this.b_53_57_HauNgoc * this.b_53_57_HauNgoc) - (4 * this.a_53_57_HauNgoc * this.c_53_57_HauNgoc);
            // TH1: delta < 0 -> Phương trình vô nghiệm
            if (delta_53_57_HauNgoc < 0)
                return "Phuong trinh vo nghiem";
            // TH2: delta = 0 -> Phương trình có nghiệm kép x = -b/2a
            else if (delta_53_57_HauNgoc == 0)
            {
                double x_53_57_HauNgoc = -this.b_53_57_HauNgoc / (2 * this.a_53_57_HauNgoc);
                return $"Nghiem kep x = {FormatNumber_53_57_HauNgoc(x_53_57_HauNgoc)}";
            }
            // TH3: delta > 0 -> Phương trình có 2 nghiệm phân biệt
            else
            {
                // Tính 2 nghiệm phân biệt x1 và x2
                double x1_53_57_HauNgoc = (-this.b_53_57_HauNgoc + Math.Sqrt(delta_53_57_HauNgoc)) / (2 * this.a_53_57_HauNgoc);
                double x2_53_57_HauNgoc = (-this.b_53_57_HauNgoc - Math.Sqrt(delta_53_57_HauNgoc)) / (2 * this.a_53_57_HauNgoc);
                // Trả về kết quả 2 nghiệm x1 và x2
                return $"x1 = {FormatNumber_53_57_HauNgoc(x1_53_57_HauNgoc)}, " +
                     $"x2 = {FormatNumber_53_57_HauNgoc(x2_53_57_HauNgoc)}";
            }
        }
    }
}