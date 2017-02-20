using System;

namespace Complex {

    class ComplexTest {
        public static void Main(string[] args) {
            Complex.zeroEvent += EventHandler;

            Complex num1 = new Complex(1, 1);
            Console.WriteLine("Num1 = " + num1);

            Complex num2 = new Complex(1, 2);
            Console.WriteLine("Num2 = " + num2);

            Complex subtract = num1 - num2;
            Console.WriteLine("Num1 - Num2 = " + subtract);

            Complex addition = num1 + num2;
            Console.WriteLine("Num1 + Num2 = " + addition);

            Complex copied = num1.Copy();
            Console.WriteLine("Num1 Copy = " + copied);

            Complex custom = num1.CustomOperation(num2, Operation);
            Console.WriteLine("Custom Function = " + custom);

            Console.WriteLine("Num1 == Num2 ? " + (num1 == num2));
            Console.WriteLine("Num1 != Num2 ? " + (num1 != num2));
            Console.WriteLine("Num1.Equals(Num2) ? " + num1.Equals(num2));

            double number = 0.50;
            Console.WriteLine("Double = " + number);
            Console.WriteLine("Casted Double = " + (Complex)number);
        }

        public static Complex Operation(Complex num1, Complex num2) {
            return new Complex(2 * (num1.real + num2.real), -1 * (num1.imaginary - num2.imaginary));
        }

        public static void EventHandler(Complex complex) {
            Console.WriteLine("Real component is zero! Complex: " + complex);
        }
    }
}