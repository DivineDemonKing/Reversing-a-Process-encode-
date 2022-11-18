Console.WriteLine("Введите послание");
string thingToEncrypt = Console.ReadLine();
Console.WriteLine("Введите ключ");
string temp = Console.ReadLine();
int key;
int.TryParse(temp, out key);
List<char> letters = new List<char>();
int temp1;
for (int i = 0; i < thingToEncrypt.Length; i++)
{
    letters.Add((char)((thingToEncrypt[i]) % 97 * key % 26 + 97));
}
Console.Write(key);
foreach (char letter in letters)
{
    Console.Write(letter);
}