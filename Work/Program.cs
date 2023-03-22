 Console.WriteLine("Ввведите что то ");
string input = Console.ReadLine();
string[] strings = new string[input.Length];
for (int i = 0; i < input.Length; i++)
{
    strings[i] = input[i].ToString();
}
int randNumArr=0;
Random rnd = new Random();
int randSizeArr=0;
randSizeArr=rnd.Next(4);
string[] stringsThree = new string[randSizeArr];

for (int i = 0; i < stringsThree.Length; i++)
{   
    randNumArr = rnd.Next(strings.Length);
    stringsThree[i]=strings[randNumArr];  
}


Console.WriteLine((string.Join(", ", strings)));
Console.WriteLine(string.Join(", ", stringsThree));
