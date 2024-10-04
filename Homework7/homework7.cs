
#region task1
//1.მოცემულია კვადრატი და კვადრატში ჩახატული წრე . ამ წრეში
//ჩახატულია კიდევ ერთი სხვა კვადრატი .
//დაწერეთ პროგრამა რომელიც იპოვის სხვაობას დიდი და პატარა კვადრატის
//ფართობებს შორის .
//Input : 5(რადიუსი)
//Output: 50

Console.Write("Enter radius: ");
double radius = double.Parse(Console.ReadLine());

double largesquareside = radius * 2;
double area1 = largesquareside * largesquareside;

double smallsquareside = radius * Math.Sqrt(2);
double area2 = smallsquareside * smallsquareside;

double areadifference = area1 - area2;

Console.WriteLine(Math.Round(areadifference));

#endregion


Console.WriteLine();

#region task2


#endregion


#region task3
//დაწერეთ პროგრამა რომელიც დათვლის ჯამში რამდენი ქულა დააგროვა
//საფეხბურთო გუნდმა
//a. მოგება - 3
//b. ფრე = 1
//c. წაგება = 0

//Input : [მოგება - 3, ფრე - 1, წაგება -1]

//Output: 10



Console.WriteLine("Task3");
Console.WriteLine("-------");


Console.Write("Enter the number of Wins: ");
int wins = int.Parse(Console.ReadLine());

Console.Write("Enter the number of Draws: ");
int draws = int.Parse(Console.ReadLine());

Console.Write("Enter the number of Losses: ");
int losses = int.Parse(Console.ReadLine());

static int CalculatePoints(int wins, int draws, int losses)
{
    return (wins * 3) + (draws * 1) + (losses * 0);
}


int totalPoints = CalculatePoints(wins, draws, losses);

Console.WriteLine($"Total Points: {totalPoints}");
#endregion

Console.WriteLine();

#region Task4
//4.დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1
//კვირის განმავლობაში. გაითვალისწინეთ
//a. დღეში თანამშრომელი მუშაობს 8 საათს და საათში იღებს 10 $
//b. ოვერთაიმის შემთხვევაში საათში იღებს დამატებით 5$
//c. შაბათ/კვირას მუშაობის შემთხვევაში იღებს გაორმაგებულ ხელფასს

//Input : 8, 8, 8, 8, 8, 0, 0
//Output: 400
//Input: 8, 8, 8, 8, 8, 8, 0
//Output: 560
//Input: 4,4,4,4,4,0,4
//Output: 280
//Input: 5,8,8,8,8,8,8
//Output: 690

Console.WriteLine("Task4");
Console.WriteLine("---------");


int totalSalary = 0;


for (int i = 1; i <= 7; i++)
{
    Console.Write($"Enter the number of hours worked on day {i}: ");
    int hours = int.Parse(Console.ReadLine());
    
    totalSalary += CalculateSalary(hours, i);
}

static int CalculateSalary(int hours, int day)
{
    const int regularRate = 10;
    const int overtimeRate = 15; // $10 + $5 for overtime
    const int weekendRate = 20; // Double salary for weekends

    int salary = 0;

    if (day < 6) // Monday to Friday (index 1 to 5)
    {
        if (hours > 8)
        {
            salary += (8 * regularRate) + ((hours - 8) * overtimeRate);
        }
        else
        {
            salary += hours * regularRate;
        }
    }
    else // Saturday and Sunday
    {
        salary += hours * weekendRate; // Double salary for weekend
    }

    return salary;
}

Console.WriteLine($"Total salary: ${totalSalary}");

#endregion


#region Task5
//5.გიორგი მარათონისთვის ემზადება ის ყოველ დღიურად ვარჯიშობს
//.შეამოწმეთ აქვს თუ არა გიორგის პროგრესი ყოველ დღიურად და გამოიტანეთ იმ
//დღეების რაოდენობა როდესაც მან შედეგი გააუმჯობესა.

//Input : 5, 8, 8, 9,10
//Output: 3
//Input: 5,5,5,5
//Output: 0
Console.WriteLine();
Console.WriteLine();




#endregion


#region Task6
//Console.WriteLine("Task6");
//Console.WriteLine("----------");


//string[] words = { "Hello", "World", "Programming", "communication" };


//Console.Write("Enter the length N: ");
//int n = int.Parse(Console.ReadLine());

//var results = words.Where(word => word.Length == n).ToList();


//if (words.Length == n)
//{
//    Console.WriteLine(results);
//}
//else
//{
//    Console.WriteLine("No elements found");
//}
    

#endregion
