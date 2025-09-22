class Program()
{
    static void Main(string[] args)
    {
        encryption();
        reverseString();
    }
    static void encryption()
    {
        Console.WriteLine("Enter a decimal number to be encrypted: ");
        string number = Console.ReadLine();
        string encryptedNum = "";

        for (int x = 0; x < number.Length; x++)
        {
            if (number[x] >= '0' && number[x] <= '9')
            {
                encryptedNum = encryptedNum + "x";
            }
            else
            {
                encryptedNum = encryptedNum + number[x];
            }
        }
        Console.WriteLine(encryptedNum);
    }

    static void reverseString()
    {
        Console.WriteLine("Enter string to be reversed: ");
        string userInput = Console.ReadLine();
        string reversedString = "";

        for (int x = userInput.Length - 1; x >= 0; x--) // this works off length being one more than the last position
        {
            reversedString = reversedString + userInput[x];
        }
        Console.WriteLine(reversedString);
    }

    static void upperCase()
    {
        Console.WriteLine("Enter string to be uppercased: ");
        string userInput = Console.ReadLine();
        string uppercasedString = "";

        for int x 
    }
}