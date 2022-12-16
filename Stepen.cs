// ЧИсло А возведение в степень B

void NumberExtent(int number, int extent)
{
    double result = Math.Pow(number,extent);
    Console.WriteLine($"{number} в степени {extent} = {result}");
}
int EnterNumber(string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int number = EnterNumber("Введите число ");
int extent = EnterNumber("Введите степень ");
NumberExtent(number,extent);

