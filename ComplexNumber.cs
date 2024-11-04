using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public struct ComplexNumber
    {
// Задание 2 Создайте структуру «Комплексное число». Определите внутри неё необходимые поля и методы. Реализуйте
// следующую функциональность:
// • Сложение комплексных чисел;
// • Вычитание комплексных чисел;
// • Умножение комплексных чисел;
// • Деление комплексных чисел. Подробнее о комплексных числах и операциях над
// ними можно прочесть тут: https://en.wikipedia.org/wiki/
// Complex_ number.



    // Действительная и мнимая части
    public double Real { get; set; }
    public double Imaginary { get; set; }

    // Конструктор для инициализации комплексного числа
    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Метод для сложения двух комплексных чисел
    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(this.Real + other.Real, Imaginary + other.Imaginary);
    }

    // Метод для вычитания двух комплексных чисел
    public ComplexNumber Subtract(ComplexNumber other)
    {
        return new ComplexNumber(this.Real - other.Real, this.Imaginary - other.Imaginary);
    }


      // Метод для деления двух комплексных чисел
    public ComplexNumber Division(ComplexNumber other)
    {
        return new ComplexNumber(this.Real / other.Real, this.Imaginary / other.Imaginary);
    }


  // Метод для деления двух комплексных чисел
    public ComplexNumber Multiply(ComplexNumber other)
    {
        return new ComplexNumber(this.Real * other.Real, this.Imaginary * other.Imaginary);
    }



    // Переопределение метода ToString для удобного вывода
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }

    }
}