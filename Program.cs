using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Программа для нахождения площади и объёма прямоугольного праллепипеда по его сторонам");
            Console.Write("Введите значение буквы a "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение буквы b "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение буквы c "); int c = Convert.ToInt32(Console.ReadLine());
            int s = b * c;
            int v = s * a;
            Console.Write("Площадь прямоугольного параллипипеда равна: " + s + " Объем прямоугольного параллепипеда равна: " + v);
            Console.ReadKey(true);
        }
    }
}