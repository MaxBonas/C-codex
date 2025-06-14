namespace AppCs.Library
{
    public static class Statistics
    {
        public static double Mean(IEnumerable<double> values)
        {
            var array = values.ToArray();
            if (array.Length == 0)
                throw new ArgumentException("Collection must contain at least one element", nameof(values));
            return array.Average();
        }

        public static double Median(IEnumerable<double> values)
        {
            var array = values.OrderBy(v => v).ToArray();
            if (array.Length == 0)
                throw new ArgumentException("Collection must contain at least one element", nameof(values));
            int mid = array.Length / 2;
            return array.Length % 2 == 0
                ? (array[mid - 1] + array[mid]) / 2.0
                : array[mid];
        }

        public static double StandardDeviation(IEnumerable<double> values)
        {
            var array = values.ToArray();
            if (array.Length == 0)
                throw new ArgumentException("Collection must contain at least one element", nameof(values));
            double mean = array.Average();
            double variance = array.Select(v => (v - mean) * (v - mean)).Average();
            return Math.Sqrt(variance);
        }
    }
}
