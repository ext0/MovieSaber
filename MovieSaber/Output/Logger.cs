using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSaber.Output
{
    public static class Logger
    {
        private static void WriteLine(LogLevel level, String output)
        {
            Console.WriteLine(String.Format(
            "[{0}] [{1}] {2:G} - {3}", MoviePlugin.Instance.Name, level.ToString(), DateTime.Now, output));
        }

        public static void Debug(String output)
        {
            WriteLine(LogLevel.DEBUG, output);
        }

        public static void Info(String output)
        {
            WriteLine(LogLevel.INFO, output);
        }

        public static void Warn(String output)
        {
            WriteLine(LogLevel.WARN, output);
        }
        public static void Error(String output)
        {
            WriteLine(LogLevel.ERROR, output);
        }

        private enum LogLevel
        {
            DEBUG,
            INFO,
            WARN,
            ERROR
        }
    }
}
