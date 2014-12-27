using System.Diagnostics;

namespace SqlExcel
{
    delegate void Action();
    static class CodeTimer
    {
        public static double ExecuteCode(Action dgMethodName)
        { 
            Stopwatch sw = new Stopwatch();
            sw.Start();
            dgMethodName.Invoke();
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
