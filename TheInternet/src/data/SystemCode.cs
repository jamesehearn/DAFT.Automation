using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace TheInternet.Data
{
    public class SystemCode
    {
        public enum Options
        {
            [Description("Option 1")]
            Option1,
            [Description("Option 2")]
            Option2,
        }
    }
}
