void FindThreeDigitElements(string[] inputArray, int countDigit)
{
    string[] outputArray = new string[countDigit];
    int i = 0;
    int k = 0;
    Console.Write("[ ");
    while (i < inputArray.Length)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[k] = inputArray[i];
            Console.Write(outputArray[k] + " ");
            i = i + 1;
            k = k + 1;
        }
        else
        {
            i = i + 1;
        }
    }
    Console.Write("]");
}

string[] mainArray = { "45", "thanks", "for", "777", "knowledge" };
int count = 0;

for (int i = count; i < mainArray.Length; i++)
{
    if (mainArray[i].Length <= 3)
    {
        count++;
    }
}

FindThreeDigitElements(mainArray, count);