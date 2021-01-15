namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if the sum of all the 2's in the array is exactly 8.
         Sum28([2, 3, 2, 2, 4, 2]) → true
         Sum28([2, 3, 2, 2, 4, 2, 2]) → false
         Sum28([1, 2, 3, 4]) → false
         */
        public bool Sum28(int[] nums)
        {
            //the sum of every 2 in the array 
            int sum = 0;
            //iterating through the int[] 
            for (int i = 0; i< nums.Length; i++)
            {
                //catches it when the value of the current position is 2
                if(nums[i] == 2)
                {
                    sum += 2;
                }
            }
            //check the final sum
            if(sum == 8)
            {
                return true;
            }

            return false;
        }
    }
}
