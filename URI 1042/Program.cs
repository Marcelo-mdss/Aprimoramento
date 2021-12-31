string[] Value = new string[3];
string[] Values = Console.ReadLine().Split(' ');

int A = int.Parse(Values[0]);
int B = int.Parse(Values[1]);
int C = int.Parse(Values[2]);

List<int> List = new List<int>();

List.Add(A);
List.Add(B);
List.Add(C);

List.Sort();

foreach (int item in List)
    Console.WriteLine(item);

Console.WriteLine();


Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
