namespace ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            //prefix product
            int[] prefixProduct = new int[nums.Length];
            prefixProduct[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                prefixProduct[i] = prefixProduct[i - 1] * nums[i-1];
            }

            int suffixProductItem = 1;
            for (int j = nums.Length-1; j >= 0; j--)
            {
                prefixProduct[j] = suffixProductItem * prefixProduct[j];
                suffixProductItem = suffixProductItem * nums[j];
            }

            return prefixProduct;
        }
    }
}
