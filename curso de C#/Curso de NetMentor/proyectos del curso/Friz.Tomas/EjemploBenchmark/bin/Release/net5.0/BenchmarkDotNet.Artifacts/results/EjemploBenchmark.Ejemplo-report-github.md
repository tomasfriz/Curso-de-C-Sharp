``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1415 (21H2)
Intel Core i5-7400T CPU 2.40GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=5.0.404
  [Host]     : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev |
|----------------------- |----------:|----------:|----------:|
| BenchmarkGenericEquals | 10.210 ms | 0.1653 ms | 0.1546 ms |
|    BenchmarkLongEquals |  7.194 ms | 0.0260 ms | 0.0244 ms |
