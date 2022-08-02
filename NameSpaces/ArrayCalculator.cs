namespace NameSpacesProject
{
    class ArrayCalculator
    {
        public int[] SortArrayAscending (int[] inputArray)
        {
            //expect to return a integer array sorted in ascending order
            int[] outputArray = new int[inputArray.Length];
            int[] currentArray = inputArray;
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                int currentBiggestNum = GetBiggestNumber(currentArray);
                int index = Array.IndexOf(currentArray,currentBiggestNum);
                //https://www.techiedelight.com/remove-specified-element-from-array-csharp/ considering multiple occurence of same element
                currentArray = currentArray.Where((e,i) => i != index).ToArray();

                outputArray[i] = currentBiggestNum;
            }
            return outputArray;
        }

        public int GetBiggestNumber (int[] inputArray)
        {
            int biggestNumber = inputArray[0];
            //expect to return the biggest number from a integer array
            foreach (var item in inputArray)
            {
                if (biggestNumber < item)
                {
                    biggestNumber = item;
                }
            }
            return biggestNumber;
        }
    }
}