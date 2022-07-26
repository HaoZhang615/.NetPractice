
bool isUpperCase (string myString) // pay attention to the method nameing convention --> to remember for long term
{ 
  foreach (var myChar in myString) //eliminate spaces of the string and turn the string into combination of characters
  {
    if (!Char.IsUpper(myChar))
    {
      return false; 
    }
  }
  return true;
}
System.Console.WriteLine(isUpperCase("THIS"));

string CharacterCaseCheck (string myString) // pay attention to the method nameing convention --> to remember for long term
{ 
  int upperCaseCounter = 0;
  int lowerCaseCounter = 0;
  string result;
  string inputWithoutWhiteSpaces = myString.Replace(" ", "");
  foreach (char myChar in inputWithoutWhiteSpaces.ToCharArray()) //eliminate spaces of the string and turn the string into combination of characters
  {
    if (Char.IsUpper(myChar))
    {
      upperCaseCounter++; 
    }
    else
    {
      lowerCaseCounter++;
    }
  }
  if (upperCaseCounter == inputWithoutWhiteSpaces.Length) 
  {
    result = "the string contains all upper cased characters"; 
  }
  else if (lowerCaseCounter == inputWithoutWhiteSpaces.Length) 
  {
    result = "the string contains all lower cased characters";
  }
  else 
  {
    result = "There are " + upperCaseCounter + " upper cased and " + lowerCaseCounter + " lower cased characters in the string";
  }
  return result;
}
System.Console.WriteLine(CharacterCaseCheck("this iS A test"));
