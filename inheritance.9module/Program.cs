using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance._9module
{
   /* 1. Создайте базовый класс «Employee», который описывает общие характеристики и поведение сотрудника компании.Класс должен содержать следующие элементы:
   - Поля: «name» (имя), «age» (возраст), «salary» (зарплата).
   - Конструктор для инициализации полей.
   - Методы:
     - «GetInfo()»: выводит информацию о сотруднике.
     - «CalculateAnnualSalary()»: рассчитывает и возвращает годовую зарплату сотрудника*/


    class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
        public Employee(string name, int age, double salary) 
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void GetInfo()
        {
            Console.WriteLine("Имя: "+ name+"\nВозраст: "+age+"\nЗарплата: "+salary);
        }

        public double CalculateAnnualSalary()
        {
            double yearsalary = salary*12;

            return yearsalary;
        }

    }

    /*  2. Создайте класс «Manager», который наследуется от «Employee». Класс «Manager» представляет 
          сотрудника с ролью менеджера и включает в себя следующие дополнительные элементы:
     - Поле: «bonus» (бонус за успешный проект).
     - Метод «CalculateAnnualSalary()»: переопределите этот метод так, чтобы он возвращал годовую зарплату с учетом бонуса.*/

    class Manager : Employee
    {
        public double bonus { get; set; }
        public Manager(string name, int age, double salary) : base(name, age, salary)
        {

        }
        public double CalculateAnnualSalary()
        {
            double yearsalary = salary*12+bonus;
            return yearsalary;
        }
    }

    /*    3. Создайте класс «Developer», который также наследуется от «Employee». Класс «Developer» представляет 
            сотрудника на позиции разработчика и включает в себя следующие дополнительные элементы:
       - Поле: «linesOfCodePerDay» (количество строк кода, написанных в день).
       - Метод «CalculateAnnualSalary()»: переопределите этот метод так, чтобы он учитывал дополнительную оплату
            за количество написанных строк кода*/

    class Developer : Employee
    {
        public int linesOfCodePerDay { get; set; }

        public Developer(string name, int age, double salary) : base(name, age, salary)
        {

        }
        public double CalculateAnnualSalary()
        {
            double yearsalary = salary * 12 + linesOfCodePerDay;

            return yearsalary;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
/*       4.В методе «Main()» создайте экземпляры классов «Manager» и «Developer», инициализируйте их поля и 
                продемонстрируйте работу переопределенных методов.*/

            Manager manager= new Manager("Reddik", 25, 30000.0);
            manager.bonus = 25000.0;
            Developer developer = new Developer("Marat", 30, 45000.0);
            developer.linesOfCodePerDay = 15000;

            double yearsalary = manager.CalculateAnnualSalary();
            Console.WriteLine("Годовая зарплата с бонусом: " + yearsalary);
            double devsalary = developer.CalculateAnnualSalary();
            Console.WriteLine("Годовая зарплата с учетаом кол-во строк кода: " + devsalary);
        }
    }
}
