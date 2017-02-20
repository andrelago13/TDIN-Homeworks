using System;


namespace Complex {
    public delegate void ZeroEvent(Complex complex);

    /**
    * Complex Number Class
    */
    public class Complex {

        public static event ZeroEvent zeroEvent;

        public delegate Complex CustomFunction(Complex number1, Complex number2);

        /**
        * Real component of the complex number
        */
        public double real {get; set;}

        /**
        * Imaginary component of the complex number
        */
        public double imaginary {get; set;}

        /**
        * Constructor of Complex number
        * @param real real component of the number
        * @param imaginary imaginary component of the number
        */
        public Complex(double real, double imaginary) {
            this.real = real;
            this.imaginary = imaginary;

            // Alert on zero real
            if(real == 0) {
                if(zeroEvent != null) {
                    zeroEvent(this);
                }
            }
        }

        public static explicit operator Complex(double real) {
            return new Complex(real, 0);
        }

        public static Complex operator +(Complex number1, Complex number2) {
            return new Complex(number1.real + number2.real, number1.imaginary + number2.imaginary);
        }

        public static Complex operator -(Complex number1, Complex number2) {
            return new Complex(number1.real - number2.real, number1.imaginary - number2.imaginary);
        }

        public static Complex operator *(Complex number1, Complex number2) {
            return new Complex(number1.real * number2.real, number1.imaginary * number2.imaginary);
        }

        public static Complex operator /(Complex number1, Complex number2) {
            return new Complex(number1.real / number2.real, number1.imaginary / number2.imaginary);
        }

        public Complex CustomOperation(Complex number, CustomFunction function) {
            return function(this, number);
        }

        public static bool operator ==(Complex number1, Complex number2) {
            return (number1.real == number2.real) && (number1.imaginary == number2.imaginary);
        }

        public static bool operator !=(Complex number1, Complex number2) {
            return !(number1 == number2);
        }

        public override bool Equals(object obj) {
            return obj.GetType() == GetType() && this == (Complex) obj;
        }

        public Complex Copy() {
            return new Complex(this.real, this.imaginary);
        }

        public override string ToString() {
            if(imaginary < 0)
                return String.Format("{0} - {1}i", real, -1 * imaginary);
            return String.Format("{0} + {1}i", real, imaginary);
        }

        public override int GetHashCode() {
            unchecked {
                int hashCode = real.GetHashCode();
                hashCode = (hashCode * 397) ^ imaginary.GetHashCode();
                return hashCode;
            }
        }
    }
}