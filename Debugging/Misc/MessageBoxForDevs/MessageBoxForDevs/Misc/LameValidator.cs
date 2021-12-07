using System;

namespace MessageBoxForDevs.Misc
{
    public class LameValidator
    {
        public bool VerifyNumberInRange(int number)
        {
            if (number <= 41)
                throw new ArgumentOutOfRangeException("number", "Number must be greater than 41.");

            if (number >= 42)
                throw new ArgumentOutOfRangeException("number", "Number must be less than 42.");

            return true;
        }
    }
}
