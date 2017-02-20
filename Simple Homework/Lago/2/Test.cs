using System;

public class Test {

    // TEST EVENTS
    public static void Main(string[] args) {
        Console.WriteLine("Hi there");
        Complex c = new Complex(2,3);
        Complex.BecameZero bz = new Complex.BecameZero(Changed);
        c.notifyBecameZero += bz;
        Console.WriteLine("1");
        c.setReal(0);
        Console.WriteLine("2");
        c.setImaginary(0);
        Console.WriteLine("3");
    }

    public static void Changed(Complex c) {
        Console.WriteLine("Changed!!!");
    }
}