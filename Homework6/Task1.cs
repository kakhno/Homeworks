#region Task1
// დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს მასივის ზომას , n
//რაოდენობის ელემენტს შეინახავს მასივში. შემდეგ ამ მასივიდან გაფილტრავს
//ელემენტს ლუწ რიცხვებს შეინახავს 1 მასივში ხოლო კენტებს მეორეში .

Console.WriteLine("TASK 1");
Console.WriteLine("----------");


Console.Write("Enter size of array: ");
int n = int.Parse(Console.ReadLine());

List<int> main = new List<int>();

for (int i = 1; i <= n; i++)
{
    main.Add(i);
}

foreach (var number in main)
{
    Console.Write(number + " ");
}

Console.WriteLine();
Console.WriteLine();


List<int> evennumbers = new List<int>();
List<int> oddnumbers = new List<int>();

foreach (var number in main)
{
    if (number % 2 == 0)
    {
        evennumbers.Add(number);
    }
    else
    {
        oddnumbers.Add(number);
    }    
}


Console.Write("Even numbers: ");
foreach (var number in evennumbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();
Console.WriteLine();

Console.Write("Odd numbers: ");
foreach (var number in oddnumbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();
#endregion






