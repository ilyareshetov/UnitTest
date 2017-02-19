using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class StringFormatter
    {
        public string WebString(string s)
        {
            string str = "", http = "http://", https = "https://", sex = "secure";
            if (!s.Contains(http) && !s.Contains(sex)) {
                str = http + s;
            }
            else if (s.Contains(sex)) {
                str = https + s;
            }

            return str;
        }
    }
}
