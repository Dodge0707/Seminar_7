/*string output = "3, 56, 78, 4, 5";

int countNumbers = 1;
for (int i = 0; i < output.Length; i++)
{
    if (output[i] == ',')
        countNumbers++;
}

int[] numbers = new int[countNumbers];

int numberIndex = 0;
for(int i = 0; i < output.Length; i++)
{
    string subString = String.Empty;

    while (output[i] != ',')
    {
        if (i >= output.Length - 1)
            break;

        subString += output[i].ToString();
        i++;
    }
    
    if(subString == "" || subString == " ")
        continue;

    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
} */


// ПЕРЕМЕШИВАНИЕ МАССИВА!!!! 

int[] numbers = { 1, 2, 3, 4, 5, 6};

for (int i = 0; i < numbers.Length; i++)
{
    int randomIndex = new Random().Next(0, numbers.Length);
    int temp = numbers[i];
    numbers[i] = numbers[randomIndex];
    numbers[randomIndex] = temp;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
