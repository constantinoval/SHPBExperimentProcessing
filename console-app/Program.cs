using System;
using ExperimentProcessingLib;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube c = new(a: 1, b: 2, l: 3);
            Console.WriteLine(c);
            Cilinder s = new(d: 5, l: 2);
            Console.WriteLine(s);
            Sample smp = new(Figures.Cube, dimensions: new double[] { 1.0, 1.0, 5.0 });
            System.Console.WriteLine(smp.SampleType);
        }
    }
}
