﻿using BenchmarkDotNet.Running;

namespace AsyncProcessingBenchmarks
{
    class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
