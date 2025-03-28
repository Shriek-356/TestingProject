using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheckerTest_06_Khang
{
    public class PalindromeChecker_06_Khang
    {
        public bool IsPalindrome_06_Khang(String text_06_Khang)
        {
            if (string.IsNullOrWhiteSpace(text_06_Khang))
            {
                return false;
            }
            text_06_Khang = text_06_Khang.ToLower().Replace(" ", "");
            int left_06_Khang=0, right_06_Khang = text_06_Khang.Length - 1;

            while (left_06_Khang < right_06_Khang)
            {
                if (text_06_Khang[left_06_Khang] != text_06_Khang[right_06_Khang])
                {
                    return false;
                }
                left_06_Khang++;
                right_06_Khang--;
            }
            return true;
        }

    }
}
