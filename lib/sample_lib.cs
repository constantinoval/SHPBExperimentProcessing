using System;

namespace ExperimentProcessingLib
{
    public enum Figures
    {
        Cube,
        Cilinder
    }
    public interface IFigure
    {
        static Figures FigType;
        double S { get; }

        double V { get; }
    }
    public class Cube : IFigure
    {
        static Figures FigType = Figures.Cube;
        public Cube(double a, double b, double l)
        {
            this.a = a;
            this.b = b;
            this.l = l;
        }
        public double a { set; get; }
        public double b { set; get; }
        public double l { set; get; }
        public double S { get => a * b; }
        public double V { get => S * l; }
        public override string ToString()
        {
            return String.Format($"{FigType}: a={a}, b={b}, l={l}");
        }
    }
    public class Cilinder : IFigure
    {
        static Figures FigType = Figures.Cilinder;
        public Cilinder(double d, double l)
        {
            this.d = d;
            this.l = l;
        }
        public double d { set; get; }
        public double l { set; get; }
        public double S { get => Math.PI * d * d / 4; }
        public double V { get => S * l; }
        public override string ToString()
        {
            return String.Format($"{FigType}: d={d}, l={l}");
        }
    }

    public class Sample
    {
        public IFigure SampleType;
        public Sample(Figures SampleType, double[] dimensions)
        {
            switch (SampleType)
            {
                case Figures.Cube:
                    this.SampleType = new Cube(dimensions[0], dimensions[1], dimensions[2]);
                    break;
                case Figures.Cilinder:
                    this.SampleType = new Cilinder(dimensions[0], dimensions[1]);
                    break;
            }
        }
        public double S { get => SampleType.S; }
        public double V { get => SampleType.V; }

    }
}
