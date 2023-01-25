using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

while (true) {
  const int N = 100000;
  Stopwatch watch = Stopwatch.StartNew();
  for (int i = 0; i != N; ++i) {
    Task t = new(delegate { });
    t.RunSynchronously();
    t.Wait();
  }
  Console.WriteLine("{0:N2} ops/s", N / watch.Elapsed.TotalSeconds);
  Thread.Sleep(TimeSpan.FromSeconds(1));
}
