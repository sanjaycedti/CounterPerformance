using System.Text;
using BenchmarkDotNet.Attributes;

namespace CounterPerformance;

[MemoryDiagnoser]
public class Benchmark
{
    [Benchmark]
    public string Increment()
    {
       return Counter.Increment("K202310000");
    }

    [Benchmark]
    public string IncrementSpan()
    {
        return Counter.IncrementSpan("K202310000");
    }
}

