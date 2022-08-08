namespace NameSpacesProject
{
    class Program
    {
        public static void Main (string[] args)
        {
            var arrayCalculater = new ArrayCalculator();

            var arrayToBeSorted = new int[] {9,5,7,2,1,8,5,3,4,-5};
            var sortedArray = arrayCalculater.SortArrayAscending(arrayToBeSorted);
            foreach (var item in sortedArray)
            {
                System.Console.WriteLine(item);
            } 

            var array = new int[] {-12,-9,-4,-7};
            var biggestNumber = arrayCalculater.GetBiggestNumber(array);
            System.Console.WriteLine(biggestNumber);

            System.Console.WriteLine("Main has successfully run");
        }
    }
}