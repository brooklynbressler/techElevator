using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SearchApplication.Util
{
    class TELog
    {
        public static void Log(string input)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter("logs/search.log", true))
                {
                    sw.WriteLine(input);
                }

            }
            catch (Exception e)
            {
                throw new TELogException(e.Message);
            }


        }   

    }
}
