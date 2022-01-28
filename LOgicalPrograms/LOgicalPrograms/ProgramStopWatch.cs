using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LOgicalPrograms
{
  
    internal class ProgramStopWatch
    {
        public void Elapsetime()
        {
            Stopwatch measuretime = new Stopwatch();
            measuretime.Start();
            measuretime.Stop();
            Console.WriteLine(" Time elapsed: {0}", measuretime.Elapsed);
        }
    }
}
