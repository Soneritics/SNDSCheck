using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SNDSCheck.Components
{
    public class IPFromTextExtracter : List<String>
    {
        public IPFromTextExtracter(String text)
        {
            var ipV4Regex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            AddRange(
                from Match match in ipV4Regex.Matches(text)
                select match.Value
            );
        }
    }
}