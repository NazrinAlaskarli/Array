int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
int temp = 0;

for (int i = 0; i <= intArray.Length - 1; i++)
{
    for (int j = i + 1; j < intArray.Length; j++)
    {
        if (intArray[i] > intArray[j])
        {
            temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }
    }
}
foreach (var item in intArray)
{
    Console.WriteLine(item);
}
Console.ReadLine();


int[] myNumbers = { 5, 1, 8, 9 };
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
    Console.WriteLine(i);
}




 int[] arr = { 8, 2, 4, 6, 12 };

int i = 0;
int sum = 0;
float average = 0.0F;

for (i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}

average = (float)sum / arr.Length;

Console.WriteLine(average);




int[] array = { 2, 4, 6, 8 };
Array.Reverse(array);

Console.WriteLine(String.Join(',', array));

