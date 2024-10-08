#region Task1
//დაწერეთ ფუნქცია რომელიც პარამეტრად მიიღებს   a, b, n 
//a. a - მინიმალური რიცხვი
//b. b - მაქსიმალური რიცხვი
//c. n - ხარისხი რომელშიც უნდა ავიყვანოთ რიცხვები
//იპოვეთ ყველა რიცხვი a - &gt; b შუალედში რომლის n ხარისხი
//მოთავსებულია ამ ინტერვალში
//Input : 49, 71 , 2 // 7^2 და 8^2 მოთავსდება ამ შუალედში
//Output: 2

//Input: 2, 27 , 4 // 2^4
//Output: 1

Console.WriteLine("Task 1");
Console.WriteLine("-------------");

Console.Write("Enter minimum number a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter maximum number b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Enter degree n: ");
int n = int.Parse(Console.ReadLine());

var count = countrange(a, b, n);
Console.WriteLine($"Count of numbers whose power {n} is in the interval [{a}, {b}]: {count}");
static int countrange(int a, int b, int n)
{
    int count = 0;

    int start = (int)Math.Ceiling(Math.Sqrt(a)); // The smallest integer whose power can be ≥ a
    int end = (int)Math.Floor(Math.Sqrt(b));     // The largest integer whose power can be ≤ b

    for (int i = start; i <= end; i++)
    {
        int pow = (int)Math.Pow(i, n); // xarisxshi akvana
        if (pow >= a && pow <= b)
        {
            count++;
        }
    }
    return count;
}
#endregion

Console.WriteLine();
Console.WriteLine();

#region Task2

//დაეხმარეთ პატარა ნიკუშას წინდების წყვილების პოვნაში. წყვილები
//აღნიშნულია ორი ერთნაირი სიმბოლოთი.
//Input : AA
//Output : 1

//Input: AABBCC
//Output : 3

//Input: AABBC
//Output : 2

Console.WriteLine("Task 2");
Console.WriteLine("-------------");


Console.Write("Enter the sock symbols: ");
string input = Console.ReadLine().ToUpper();

int result = CountSockPairs(input);
Console.Write($"The number of pairs of socks is: {result}");


static int CountSockPairs(string input)
{
    int[] counts = new int[26]; // 26 letters in the english alphabet


    foreach (char sock in input)
    {
        if (sock >= 'A' && sock <= 'Z')
        {
            counts[sock - 'A']++; // INDEX gazrda
                                  //A aris 65 ASCII cxrilshi, B - 66, C = 67
                                  // magalitad: sock = C -> 'C' - 'A' = 2 (INDEX)
        }
    }

    int pairs = 0;

    foreach (int count in counts)
    {
        pairs = pairs + count / 2; // Shemova 'A' magalitad mis indeqsze 5 dgas, 5/2 = 2, shemdeg gadava 'B'
    }

    return pairs;
}


#endregion

Console.WriteLine();
Console.WriteLine();

#region Task3
//დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა გრძელ საერთო
//ბოლოსართს ორ სტრინგს შორის .
//Input : multiplication , substraction
//Output : tion
//Input : Some Random Text, It is Some Random Text
//Output : Some Random Text

Console.WriteLine("Task 3");
Console.WriteLine("-------------");


Console.WriteLine("Enter the first string:");
string str1 = Console.ReadLine();

Console.WriteLine("Enter the second string:");
string str2 = Console.ReadLine();

string resultt = LongestCommonSubstring(str1, str2);
Console.WriteLine($"Output: {resultt}");


static string LongestCommonSubstring(string str1, string str2)
{
    int[,] lengths = new int[str1.Length + 1, str2.Length + 1];
    int longestLength = 0;
    int longestEndIndex = 0;

    for (int i = 1; i <= str1.Length; i++)
    {
        for (int j = 1; j <= str2.Length; j++)
        {
            if (str1[i - 1] == str2[j - 1]) // Characters match
            {
                lengths[i, j] = lengths[i - 1, j - 1] + 1;
                if (lengths[i, j] > longestLength)
                {
                    longestLength = lengths[i, j];
                    longestEndIndex = i; // End index of the longest substring in str1
                }
            }
            else
            {
                lengths[i, j] = 0; // No match
            }
        }
    }

    // Extract the longest common substring
    return str1.Substring(longestEndIndex - longestLength, longestLength);
}


#endregion


Console.WriteLine();
Console.WriteLine();

#region Task5

//რეკურსია
//დაწერეთ ფუნქცია რომელიც დაბეჭდავს რიცხვში შემავალ ყოველ სიმბოლოს .
//Input : 12345
//Output: 1 - 2 - 3 - 4 - 5

Console.WriteLine("Task 5");
Console.WriteLine("-------------");


Console.WriteLine("Enter a number:");
string inputt = Console.ReadLine();

PrintCharacters(inputt);


static void PrintCharacters(string number)
{
    PrintRecursively(number, 0);
}

static void PrintRecursively(string number, int index)
{
    // Base case: if the index reaches the length of the number, return
    if (index >= number.Length)
    {
        return;
    }

    // Print the current character
    Console.Write(number[index]);

    // Check if it's not the last character to print the separator
    if (index < number.Length - 1)
    {
        Console.Write(" - ");
    }

    // Recursive call to print the next character
    PrintRecursively(number, index + 1);
}

#endregion


Console.WriteLine();
Console.WriteLine();

#region Task6

//დაწერეთ პროგრამა რომელიც შეამოწმებს შეიცავს თუ არა მასივი
//დუბლიკატებს
//Input: nums = [1, 2, 3, 1]
//Output: true
//Input: nums = [1, 2, 3, 4]
//Output: false


Console.WriteLine("Task 6");
Console.WriteLine("-------------");

int[] nums1 = { 1, 2, 3, 1 };
int[] nums2 = { 1, 2, 3, 4 };

Console.WriteLine($"Input: [{string.Join(", ", nums1)}]");
Console.WriteLine($"Output: {HasDuplicates(nums1)}");

Console.WriteLine($"Input: [{string.Join(", ", nums2)}]");
Console.WriteLine($"Output: {HasDuplicates(nums2)}");

static bool HasDuplicates(int[] nums)
{
    Array.Sort(nums);

    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] == nums[i + 1])
        {
            return true; // Duplicate found
        }
    }
    return false; // No duplicates
}
#endregion