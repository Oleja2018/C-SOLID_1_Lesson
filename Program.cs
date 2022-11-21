// See https://aka.ms/new-console-template for more information
using System;

namespace Homework; //Пришлось с 0 вспоминать струкутуру
class Program
{
    public static void Main(string[] args)
    {
        Program Lesson = new Program();
        OutputAnswer();
        double[] Massive = Lesson.Input(); // Вызов метода ввода
        double HypotenuseResult = Lesson.HypotenuseTriangle(Massive); // Вызов метода вычисления
        Lesson.ExistsTriangle(Massive, HypotenuseResult); // Вызов метода проверки
        Lesson.Output(Massive); // Вызов метода вывода
        bool status = Lesson.ExistsTriangle(Massive, HypotenuseResult);
        Console.WriteLine($"Статус существования треугольника: {status} ");

    }
    public static void OutputAnswer() // Хотел сделать крассивый вывод задания)
    {
        Console.WriteLine("Задача: Реализовать метод с параметрами, ветвлением и циклами, \n ввод, вывод , взаимодействие ОС Нет смысла реализовать все в одном методе, создам разные для работы с геометрией,\n там и реализую.");

    }
    private double[] Input() // Метод ввода, согласно уроку #1 не пишем Console.WriteLine
    {
        Console.WriteLine("A");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("B");
        double b = Convert.ToDouble(Console.ReadLine());
        double[] MyArr = { a, b };

        return MyArr;
    }
    private double HypotenuseTriangle(double[] MyArr)
    {
        double Cathet_A = MyArr[0];
        double Cathet_B = MyArr[1];

        double Hypotenuse = Math.Sqrt(Cathet_A * Cathet_A + Cathet_B * Cathet_B);
        Console.WriteLine($"Гипотенуза: {Hypotenuse}");
        return Hypotenuse;
    }
    private bool ExistsTriangle(double[] MyArr, double Hypotenuse) // Метод для проверки существования треугольника путем Т.Пифагора
    {
        bool result;

        double Cathet_A = MyArr[0];
        double Cathet_B = MyArr[1];
        

        if ((Cathet_A + Cathet_B != Hypotenuse) & (Cathet_A> 0 & Cathet_B > 0)) // Реализация условного оператора
        {
            result = true;
        }
        else {
            result = false;

        }

        return result;
    }
    private double[] Output(double[] MyArr) // Метод вывода, согласно уроку #1 не пишем Console.WriteLine
    {
        Console.WriteLine("Output...Initialization");
        for (int i = 0; i < 2; i++) // Цикл реализован
        {
            Console.WriteLine(MyArr[i]);
        }
        DateTime dateTime = DateTime.Now; // Работа с OC
        Console.WriteLine(dateTime);
        return MyArr;
    }



};


