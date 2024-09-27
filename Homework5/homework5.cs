#region 1. შეამოწმეთ იყოფა თუ არა რიცხვი 5ზე უნაშთოდ. რიცხვი უნდა მიიღოთ კონსოლიდან.
Console.WriteLine("TASK 1");
Console.WriteLine("----------");


Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

if (num % 5 == 0) 
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("No");
}

Console.WriteLine();
Console.WriteLine();
#endregion

#region 2. დაწერეთ ისეთი პროგრამა, რომელიც შეასრულებს ჯამის, სხვაობის, ნამრავლის და გაყოფის მოქმედებებს
/*შენიშვნა:
i. გაყოფის და გამოკლების დროს აარჩიეთ უდიდესი და მას გამოაკელით უმცირესი
ii. თუ უმცირესი რიცხვი იქნება 0 პროგრამამ უნდა გამოიტანოს შეცდომა 0 გაყოფა არ შეიძლება . 
*/

Console.WriteLine("TASK 2");
Console.WriteLine("----------");


Console.Write("Enter first number: ");
var a = int.Parse(Console.ReadLine());

Console.Write("Enter Second number: ");
var b = int.Parse(Console.ReadLine());

var maxx = Math.Max(a, b);
var minn = Math.Min(a, b);

Console.WriteLine();

Console.Write("Sum: ");
Console.WriteLine(maxx+minn);

Console.WriteLine();

Console.Write("Subtraction: ");
Console.WriteLine(maxx - minn);

Console.WriteLine();

Console.Write("Multiplication: ");
Console.WriteLine(maxx * minn);

Console.WriteLine();

Console.Write("Division: ");
if (minn == 0)
{
    Console.WriteLine("Not Allowed To Divide By Zero");
}
else
{
 Console.WriteLine(maxx / minn);
}

#endregion

#region 3. გაუცვალეთ ორ ცვლადს შორის მნიშვნელობები

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("TASK 3");
Console.WriteLine("----------");


Console.Write("Enter Firstnum: ");
var firstnum = Console.ReadLine();

Console.Write("Enter Secondnum: ");
var secondnum = Console.ReadLine();

(firstnum, secondnum) = (secondnum, firstnum);

Console.WriteLine($"After exchange: Firstnum = {firstnum}, Secondnum = {secondnum}");

#endregion

#region 4.დაწერეთ პროგრამა რომელიც მიიღებს კონსოლიდან 1 რიცხვს და დაბეჭდავს გამრავლების ტაბულას ამ რიცხვისთვის

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("TASK 4");
Console.WriteLine("----------");


int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{number} * {i} = {number * i}");
}

#endregion

#region 5. დაწერეთ პროგრამა რომელიც იპოვის ყველა ლუწ რიცხვს 1 დან n - მდე და დაბეჭდავს მათ კვადრატებს .

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("TASK 5");
Console.WriteLine("----------");


Console.Write("Enter a number: ");
int numm = Convert.ToInt32(Console.ReadLine());

for(int i = 2; i < numm; i += 2)
{
    int square = i * i;
    Console.WriteLine(square);

}

#endregion