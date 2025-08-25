namespace Solution
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int GetMissingNumber(int[] nums)
        {
            int count = nums.Length;
            long expectedSum = (long)count * (count + 1) / 2;
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += nums[i];
            }

            return (int)(expectedSum - sum);
        }
    }
}
