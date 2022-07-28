// approach 1 with for loop
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

// approach 2 with Array.Reverse method
bool isPalindrom2 (string stringToTest)
{
    char [] tempCharArray = stringToTest.ToCharArray();
    // Array.Reverse is a method with void type, means doesn't return anything
    Array.Reverse(tempCharArray);
    // convert char array to a string
    //alternative: string newString = new string(tempCharArray);
    string newString = string.Join("",tempCharArray);
    //return new string(Array.Reverse(array));
    return newString == stringToTest;
}

System.Console.WriteLine(isPalindrom2("racecar"));