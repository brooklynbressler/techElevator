namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
         Has22([1, 2, 2]) → true
         Has22([1, 2, 1, 2]) → false
         Has22([2, 1, 2]) → false
         */
        public bool Has22(int[] nums)
        {
            //iterate through the int[]
            for(int i = 0; i < nums.Length; i++)
            {
                //when doing i+1 outOfBounds is a possibility 
                int outOfBoundsCheck = nums.Length - 1;
                //if the index is less than or equal to 1 then the only other 2 could only be in the 
                //next position 
                if(i <= 1 && nums[i] == 2 && nums[i + 1] == 2)
                {
                    return true;
                }
                //make sure i isn't in out of bounds territory 
                if (i >1 && i < outOfBoundsCheck)
                {
                    //now check for the possibility with the index being in the middle 
                    //check the position before and then the one ahead if either = 2 
                    if (nums[i] == 2 && nums[i-1] ==2 || nums[i] == 2 && nums[i+1] == 2)
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }
    }
}
