Console.Write("Введите строку: ");
string str = Console.ReadLine().ToLower();

Console.Write("Введите символ: ");
string input = Console.ReadLine();
char charr = char.ToLower(input[0]); 

int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == charr)
    {
        count++;
    }
}

Console.WriteLine($"Символ '{charr}' встречается в строке {count} раз(а).");