namespace AppCs.Library
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        public int Power(int baseValue, int exponent)
        {
            if (exponent < 0)
                throw new ArgumentException("Exponent must be non-negative", nameof(exponent));
            int result = 1;
            for (int i = 0; i < exponent; i++)
                result *= baseValue;
            return result;
        }

        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("n must be non-negative", nameof(n));
            int result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        public int Gcd(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
