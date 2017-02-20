using System;
using System.Threading;
using System.Threading.Tasks;

public class Pi {

    public const double NRECS = 1000000000;
    public const double w = 1/NRECS;

    public static async void calculatePI_Async() {
        double res = await Task.Run<double>( () => calculatePI() );
        Console.WriteLine("PI: " + res);
    }

    public static double calculatePI() {
        double pi = 0;

        for(int k = 0; k < NRECS; ++k) {
            pi += f((k+0.5)*w)*w;
        }

        return pi;
    }

    public static double f(double x) {
        return 4 / (double) (1 + x*x);
    }

    public static void Main(string[] args) {
        Console.WriteLine("Starting calculation");

        calculatePI_Async();
        Thread.Sleep(20000);

        Console.WriteLine("Calculation ended");
    }

}