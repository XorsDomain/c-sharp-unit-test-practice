using System;

namespace MonkeyTesting
{
    public class MonkeyTrouble
    {
        public bool Trouble(bool aSmile, bool bSmile)
        {
            if (aSmile != bSmile)
            {
                return false;
            }
            // else 
            // {
            //     return true;
            // }
            return true;
        }
    }
}
