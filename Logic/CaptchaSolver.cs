using System;

namespace Logic
{
    public class CaptchaSolver
    {
        public int Solve(string captcha)
        {
            int sum = 0;
            for (int i = 0; i < captcha.Length; i++)
            {
                var currentDigit = int.Parse(captcha[i].ToString());
                var nextDigit = int.Parse(captcha[(i + 1) % captcha.Length].ToString());
                if (currentDigit == nextDigit)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}
