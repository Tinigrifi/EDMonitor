namespace EDMonitor.Helpers
{
    public static class IntExtension
    {
        public static string ToDisplay(this int intToDisplay)
        {
            string s = intToDisplay.ToString();
            string ret = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    ret = " " + ret;
                }
                ret = s[s.Length - i - 1] + ret;
            }
            return ret;
        }
    }
}