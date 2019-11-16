using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    //Static class to show the use of interfaces and maintainability
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
