//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
int Prompt(string message)
    {   
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
    };
    int numberMax=0;
    int numberA = Prompt("Введите первое число");
    int numberB = Prompt("Введите второе число");
    int numberC = Prompt("Введите третье число");
        if (numberA > numberB)
        {
             numberMax = numberA;
        }   
        else numberMax = numberB;
        if (numberMax > numberC)
        {
           Console.WriteLine("max = " + numberMax);
        }
        else 
        {
            Console.WriteLine("max = " + numberC);
        }
