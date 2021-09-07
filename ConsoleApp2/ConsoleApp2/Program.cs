using System;

namespace ConsoleApp2
{
    class Program
    {
        public static string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", "!", "&", "@", "#", "$", "%", "^", "*", "(", ")", "-", "_", "=", "+" };
        public static string[] alphabet_crypt = new string[] { "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", "!", "&", "@", "#", "$", "%", "^", "*", "(", ")", "-", "_", "=", "+", "a", "b", "c", "d", "e" };
        static void Main(string[] args)
        {
            Console.Title = "Шифровка/Расшифровка";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Вы хотите расшифровать или зашифровать сообщение?");
                Console.WriteLine("1 - Зашифровать");
                Console.WriteLine("2 - Расшифровать");
                int main;
                while (true)
                {
                    try
                    {
                        main = int.Parse(Console.ReadLine());
                        if (main == 1 || main == 2)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Партия китая разочарованна в вас у вас забрать миска риса и кошка девочка!");
                        Console.WriteLine("Попробуй еще раз");
                    }
                }
                
                if (main == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите сообщение");
                    string message = Console.ReadLine();
                    string result = UNCrypt_Text(message);
                    Console.WriteLine("Результат:");
                    Console.WriteLine(result);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Введите сообщение");
                    string message = Console.ReadLine();
                    string result = Crypt_Text(message);
                    Console.WriteLine("Результат:");
                    Console.WriteLine(result);
                }
            }
        }

        public static string Crypt_Text(string text)
        {
            string trash;
            string result = "";
            string trashx2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                trash = Convert.ToString(text[i]);
                for (int i2 = 0; i2 < alphabet.Length; i2++)
                {
                    if (trash == alphabet[i2])
                    {
                        trashx2 = Convert.ToString(i2);
                        break;
                    }
                }
                result = result + alphabet_crypt[int.Parse(trashx2)];
            }
            return result;
        }

        public static string UNCrypt_Text(string text)
        {
            string trash;
            string result_uncrypt = "";
            string trashx2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                trash = Convert.ToString(text[i]);
                for (int i2 = 0; i2 < alphabet_crypt.Length; i2++)
                {
                    if (trash == alphabet_crypt[i2])
                    {
                        trashx2 = Convert.ToString(i2);
                        break;
                    }
                }
                result_uncrypt = result_uncrypt + alphabet[int.Parse(trashx2)];
            }
            return result_uncrypt;
        }


    }
}
