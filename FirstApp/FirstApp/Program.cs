// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] numbers)
{
    int sumTpm = 0;
    foreach (var number in numbers)
    {
        sumTpm += number;
    }

    return (double) sumTpm / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);


static int GetMaxFromTab(int[] numbers)
{
    int tmp = Int32.MaxValue;
    foreach (var number in numbers)
    {
        if (number > tmp)
        {
            tmp = number;
        }
    }
    return tmp;
}