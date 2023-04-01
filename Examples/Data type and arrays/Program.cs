//defined input and output

using System.Reflection.Metadata;

string str = "My First string";
int a = 10;
double d = 3.90;
char c = 'a';
var k = "okay";
const int i = 3;


Console.WriteLine("Print declared elements value ----");
Console.WriteLine(str);
Console.WriteLine(a);
Console.WriteLine(d);
Console.WriteLine(c);
Console.WriteLine(k);
Console.WriteLine(i);

//User type input ouput


string str2 = Console.ReadLine();
Console.WriteLine("input string : " + str2);
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input integer : " + b);
double e = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input double : " + e);
char ch = 'c';
Console.WriteLine("input character : " + ch);
var ap = Console.ReadLine();
Console.WriteLine("input var element : " + ap);

//Array input output

//One dimensionl array
Console.WriteLine("Example of one dimwntional array : ");
string[] str3 = Console.ReadLine().Split(" ");
foreach (string x in str3)
{
    Console.WriteLine(x);
}

//Two dimwntional array

Console.WriteLine("Example of Two dimwntional array : ");
int[,] matrix = new int[3, 4] {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }
};

for (int s = 0; s < 3; s++)
{
    for (int j = 0; j < 4; j++)
    {
        int value = matrix[i, j];
        Console.Write(value + " ");
    }
    Console.WriteLine();
}

//Jagged array
Console.WriteLine("Example of jagged array : ");
int[][,] Jagger = new int[][,]
{
        new int[, ] {{1, 3}, {5, 7}},
        new int[, ] {{0, 2}, {4, 6}, {8, 10}},
        new int[, ] {{11, 22}, {99, 88}, {0, 9}}
};
for (int one = 0; one < Jagger.Length; one++)
{
    int value = 0;
    for (int two = 0; two < Jagger[one].GetLength(value); two++)
    {
        for (int p = 0; p < Jagger[two].Rank; p++)
            Console.Write("Jagged Array[" + one + "][" + two + ", " + p + "] = "
                                        + Jagger[one][two, p] + "   ");
        Console.WriteLine();
    }
}