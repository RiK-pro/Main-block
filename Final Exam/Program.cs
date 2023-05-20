string[] originalArray = { "hello", "world", "this", "is", "a", "test", "for", "exam" };

string[] newArray = new string[originalArray.Length];
int index = 0;

for (int i = 0; i < originalArray.Length; i++)
{
    if (originalArray[i].Length <= 3)
    {
        newArray[index] = originalArray[i];
        index++;
    }
}

Console.WriteLine("New array:");
for (int i = 0; i < index; i++)
{
    Console.WriteLine(newArray[i]);
}

Console.ReadLine();