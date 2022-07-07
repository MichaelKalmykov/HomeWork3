Console.WriteLine ("Введите пятизначное число");
string number = Console.ReadLine();
int lenght = number.Length;

if (lenght < 5 || lenght > 5)
    {
        Console.WriteLine("Это не пятизначное число");    
    }
else
    {
        if (number[0]==number[4] || number[1]==number[3])
            {
                Console.WriteLine("Ваше число - палиндром.");
            }
        else
            {
                Console.WriteLine("Ваше число - не палиндром.");
            }
    }