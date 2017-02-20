    using System;
    using static System.Math;

    public class Complex {
        private double real;
        private double imaginary;

        public delegate double ModifyReal(Complex toModify);
        public delegate void BecameZero(Complex zeroed);

        // Used to notify when Complex becomes zero
        public event BecameZero notifyBecameZero;

        public Complex(double real, double imaginary) {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Copy constructor
        public Complex(Complex comp) {
            this.real = comp.real;
            this.imaginary = comp.imaginary;
        }

        public double GetReal() {
            return real;
        }

        public double GetImaginary() {
            return imaginary;
        }

        public double GetModule() {
            return Sqrt(Pow(real, 2) + Pow(imaginary, 2));
        }

        public double GetPhase() {
            if(real > 0) {
                return Atan(imaginary / real);
            }

            if(real < 0 && imaginary >= 0) {
                return Atan(imaginary / real) + PI;
            }

            if(real < 0 && imaginary < 0) {
                return Atan(imaginary / real) - PI;
            }

            if(real == 0 && imaginary > 0) {
                return PI / 2;
            }

            if(real == 0 && imaginary < 0) {
                return - PI / 2;
            }

            return 0;
        }

        public void setReal(double real) {
            this.real = real;

            if(this.real == 0 && this.imaginary == 0) {
                notifyBecameZero(this);
            }
        }

        public void setImaginary(double img) {
            imaginary = img;

            if(this.real == 0 && this.imaginary == 0) {
                notifyBecameZero(this);
            }
        }

        // Operator overload
        public static Complex operator +(Complex c1, Complex c2) {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        // Conversion overload
        public static explicit operator Complex(double b)
        {
            return new Complex(b, 0);
        }

        public void modify(ModifyReal md) {
            real = md(this);
        }
    }