using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoObject
{
    public class ThermoObjectC
    {
        public static List<ThermoObjectC> Codes = new List<ThermoObjectC>();
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Account { get; set; }
        public string Code { get; set; }
        public ThermoObjectC(string Name, DateTime Date, string Account, string Code)
        {
            this.Name = Name;
            this.Date = Date;
            this.Account = Account;
            this.Code = Code;
        }
    }
}
