using BenchmarkDotNet.Running;
using CounterPerformance;

BenchmarkRunner.Run<Benchmark>();

return;

var result = Counter.Increment("K202310000");

Console.WriteLine(result);

var resultSpan = Counter.IncrementSpan("K202310000");

Console.WriteLine(resultSpan);
