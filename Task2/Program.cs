// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
int SumOfDigits(int x) {
    int sum = 0;
    
     for (int i = 0; x > 0; i++) 
     {
        sum = sum + x % 10;
        x /= 10;
     }
     return sum;
}

int GetNumber(string str){
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

Console.Clear();

int x = GetNumber("Введите число: ");

int sum = SumOfDigits(x);

Console.WriteLine($"Сумма цифр числа {x} равна {sum}.");
