using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheckerTest_06_Khang {
    public class PalindromeChecker_06_Khang
    {
        //Phương thức này nhận vào một chuỗi và kiểm tra nếu nó là Palindrome
        public bool IsPalindrome_06_Khang(String text_06_Khang)
        {
            //Nếu chuỗi rỗng hoặc chỉ chứa khoảng trắng, trả về false (không phải Palindrome)
            if (string.IsNullOrWhiteSpace(text_06_Khang))
            {
                return false;
            }

            //Chuyển toàn bộ chuỗi về chữ thường và loại bỏ khoảng trắng để chuẩn hóa trước khi kiểm tra
            text_06_Khang = text_06_Khang.ToLower().Replace(" ", "");

            // Khai báo hai chỉ số, một chỉ số bắt đầu từ đầu chuỗi, một chỉ số bắt đầu từ cuối chuỗi
            int left_06_Khang = 0, right_06_Khang = text_06_Khang.Length - 1;

            //Kiểm tra từng cặp ký tự từ hai đầu, nếu không khớp thì không phải Palindrome
            while (left_06_Khang < right_06_Khang)
            {
                //Nếu ký tự ở vị trí left không khớp với ký tự ở vị trí right, trả về false
                if (text_06_Khang[left_06_Khang] != text_06_Khang[right_06_Khang])
                {
                    return false;
                }

                //Di chuyển chỉ số về phía giữa chuỗi
                left_06_Khang++;
                right_06_Khang--;
            }

            //Nếu vòng lặp kết thúc mà không có sự khác biệt nào, chuỗi là Palindrome
            return true;
        }
    }
}
