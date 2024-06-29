using System;

public class Student
{
    // Свойства класса
    public string Name { get; set; }
    public int Age { get; set; }
    public double AverageGrade { get; set; }

    // Конструктор класса
    public Student(string name, int age, double averageGrade)
    {
        Name = name;
        Age = age;
        AverageGrade = averageGrade;
    }

    // Метод для вывода информации о студенте
    public void PrintInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}, Average Grade: {AverageGrade}");
    }

    // Метод для подсчета оценки студента на основе среднего балла
    public string CalculatePerformance()
    {
        if (AverageGrade > 8)
        {
            return "Отлично";
        }
        else if (AverageGrade >= 6 && AverageGrade <= 8)
        {
            return "Хорошо";
        }
        else if (AverageGrade >= 4 && AverageGrade < 6)
        {
            return "Удовлетворительно";
        }
        else
        {
            return "Неудовлетворительно";
        }
    }

    // Дополнительные методы и свойства могут быть добавлены по вашему усмотрению
}

class Program
{
    static void Main()
    {
        // Создание объектов класса Student
        Student student1 = new Student("Иванов Иван", 20, 7.5);
        Student student2 = new Student("Петров Петр", 21, 9.2);
        Student student3 = new Student("Сидорова Анна", 19, 5.8);

        // Вывод информации о студентах и их оценках
        student1.PrintInfo();
        Console.WriteLine("Оценка: " + student1.CalculatePerformance());

        student2.PrintInfo();
        Console.WriteLine("Оценка: " + student2.CalculatePerformance());

        student3.PrintInfo();
        Console.WriteLine("Оценка: " + student3.CalculatePerformance());

        // Пример изменения данных студента и повторный вывод информации
        student3.AverageGrade = 6.9;
        student3.PrintInfo();
        Console.WriteLine("Оценка: " + student3.CalculatePerformance());
    }
}
