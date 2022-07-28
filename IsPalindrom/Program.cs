//Step 1 - create a new empty string "container"
//step 2 - read the input string "backwards" and load the characters one by one into the new empty string "container"
//step 3 - compare if the new string equals to the input string

bool isPalindrom (string stringToTest) 
{ 
    //Step 1 - create a new empty string "container"
    string stringReversed = "";
    //step 2 - read the input string "backwards" and load the characters one by one into the new empty string "container"
    for (int i = stringToTest.ToCharArray().Length-1; i >= 0; i--)
    { 
        stringReversed += stringToTest.ToCharArray()[i];
    }

    return stringToTest == stringReversed;
  
}
System.Console.WriteLine(isPalindrom("racecar"));