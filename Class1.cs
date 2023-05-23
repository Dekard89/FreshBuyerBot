using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBuyerBot
{
    internal static class CalculatorSG
    { 
        

        static public string BestBeforeDate(DateTime birthsDay, DateTime dathDay)
        {
            TimeSpan result= dathDay.Subtract(birthsDay);
            return result.ToString();
        }   
        static public string Remainder(DateTime births, DateTime dathDay)
        {
            DateTime now = DateTime.Today;
            TimeSpan res= dathDay.Subtract(now);

            return res.ToString();
        }
        
    }
}
