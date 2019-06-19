using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleLogging
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();//log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Debug("This is debug log..");
            log.Error("This is error log..");
            Console.ReadLine();
        }
    }
}
