namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return the number of even ints in the given array. Note: the % "mod" operator computes the
         remainder, e.g. 5 % 2 is 1.
         CountEvens([2, 1, 2, 3, 4]) → 3
         CountEvens([2, 2, 0]) → 3
         CountEvens([1, 3, 5]) → 0
         */
        public int CountEvens(int[] nums)
        {
            //even number counter to keep track of evens 
            int evenCounter = 0;
            //iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                //if the remainder equals 0 then the value is even 
                if(nums[i] % 2 == 0)
                {
                    //increments the even number counter by 1
                    evenCounter++;
                }
            }
            //return the amount of times an even number was found 
            return evenCounter;
        }
    }
}
