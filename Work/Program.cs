Console.WriteLine("Ввведите что то ");
string input = Console.ReadLine();
string[] strings = new string[input.Length];
for (int i = 0; i < input.Length; i++)
{
    strings[i] = input[i].ToString();
}