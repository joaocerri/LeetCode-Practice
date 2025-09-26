public class Solution
{
    public void SortColors(int[] nums)
    {
        int low = 0;        
        int mid = 0;       
        int high = nums.Length - 1;  

        while (mid <= high)
        {
            if (nums[mid] == 0)
            {
                Swap(nums, low, mid);
                low++;
                mid++;
            }
            else if (nums[mid] == 1)
            {
                mid++;
            }
            else
            { 
                Swap(nums, mid, high);
                high--;
            }
        }
    }

    private void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 2, 0, 2, 1, 1, 0 };
        solution.SortColors(nums);
        Console.WriteLine(string.Join(", ", nums)); 
    }
}

