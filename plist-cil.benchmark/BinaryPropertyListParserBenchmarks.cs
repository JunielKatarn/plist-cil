﻿using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace Claunia.PropertyList.Benchmark
{
    [CoreJob]
    [MemoryDiagnoser]
    public class BinaryPropertyListParserBenchmarks
    {
        byte[] data;

        [GlobalSetup]
        public void Setup()
        {
            data = File.ReadAllBytes("plist.bin");
        }

        [Benchmark]
        public NSObject ReadLargePropertylistTest()
        {
            NSObject nsObject = PropertyListParser.Parse(data);
            return nsObject;
        }
    }
}