public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] resultado = nums1.Concat(nums2).OrderBy(x => x).ToArray();

        if (resultado.Length % 2 == 0)
            return (resultado[(resultado.Length - 1) / 2] + resultado[(resultado.Length) / 2]) / 2.0;
        else
            return resultado[resultado.Length / 2];
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums1 = { 1, 3 };
        int[] nums2 = { 2 };
        double median = solution.FindMedianSortedArrays(nums1, nums2);
        Console.WriteLine($"The median is: {median}");
    }
}