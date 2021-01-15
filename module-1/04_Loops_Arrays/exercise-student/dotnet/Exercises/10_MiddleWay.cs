namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle
         elements.
         MiddleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
         MiddleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
         MiddleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
         */
        public int[] MiddleWay(int[] a, int[] b)
        {
            //new array that we're returning later with the middle positions of int[] a and int[] b
            //put 2 in there so 2 values are in the array also in the notes 
            int[] newArr = new int[2];
            //iterate through int[] a and use the index for int[] b as well 
            //since they're both the same length
            for(int i = 0; i < a.Length; i++)
            {
                //check the index for the middle position 
                if(i == 1)
                {
                  newArr[0] = a[i];
                  newArr[1] = b[i];
                }
            }
            //return new array
            return newArr;
        }
    }
}
