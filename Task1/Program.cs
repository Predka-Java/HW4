// Напишите цикл, который принимает на вход 2 числа и возводит первое в натуральную степерь второго.
int Exponentiation(int x, int y) {
    int res = x;
    for (int i = 1; i < y; i++)
    {
        res = res * x;
    }
    return res;
}

int GetNumber(string str){
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Console.Clear();
int x = GetNumber("Введите число: ");

int y = GetNumber("Введите степень: ");
int exp = Exponentiation(x, y);
Console.WriteLine($"Число {x} в степени {y} равно {exp}.");