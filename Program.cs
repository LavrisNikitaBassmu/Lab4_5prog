using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Слова, начинающиеся с большой буквы и заканчивающиеся на две цифры:");

        foreach (var word in words)
        {
            if (IsValidWord(word))
            {
                Console.WriteLine(word);
            }
        }
    }

    static bool IsValidWord(string word)
    {
        // Проверка на начало с большой буквы и наличие двух цифр в конце
        if (word.Length < 3) return false; // Слово должно иметь хотя бы 3 символа
        if (char.IsUpper(word[0]) && char.IsDigit(word[word.Length - 1]) && char.IsDigit(word[word.Length - 2]))
        {
            // Проверяем, что перед последними двумя цифрами нет других цифр
            for (int i = 0; i < word.Length - 2; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    return false; // Если есть цифры перед последними двумя, то слово не подходит
                }
            }
            return true;
        }
        return false;
    }
}