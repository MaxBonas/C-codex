namespace AppCs.Library
{
    public static class PrimeNumberUtils
    {
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int boundary = (int)Math.Sqrt(n);
            for (int i = 3; i <= boundary; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static IEnumerable<int> GetPrimesUpTo(int max)
        {
            if (max < 2) yield break;
            for (int i = 2; i <= max; i++)
            {
                if (IsPrime(i))
                    yield return i;
            }
        }

        public static List<int> PrimeFactors(int n)
        {
            if (n <= 1)
                throw new ArgumentException("n must be greater than 1", nameof(n));

            List<int> factors = new();
            int num = n;

            for (int i = 2; i * i <= num; i++)
            {
                while (num % i == 0)
                {
                    factors.Add(i);
                    num /= i;
                }
            }

            if (num > 1)
                factors.Add(num);

            return factors;
        }
    }
}
