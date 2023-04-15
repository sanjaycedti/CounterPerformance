# CounterPerformance

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.1 (22C65) [Darwin 22.2.0]
Apple M1 Pro, 1 CPU, 8 logical and 8 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 7.0.5 (7.0.523.17405), Arm64 RyuJIT AdvSIMD


|        Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|-------------- |---------:|---------:|---------:|-------:|----------:|
|     Increment | 97.89 ns | 0.060 ns | 0.056 ns | 0.0293 |     184 B |
| IncrementSpan | 32.69 ns | 0.026 ns | 0.025 ns | 0.0076 |      48 B |
