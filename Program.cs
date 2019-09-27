using Course.Entities;
using System.Globalization;
using Course.Entities.Enums;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department´s name: "); //Entra com dados do departamento
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: "); //Entre com dados  trabalhador
            Console.Write("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Level(Junior/MidLevel/Senior:");//Nível do trabalhador
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);    //Aqui foi instanciado classe Department
            Worker worker = new Worker(name, level, BaseSalary, dept);

            Console.WriteLine("How many Contracts to this Worker? "); //Quantos Contratos vai cadastrar para esse trabalhador
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter # {i} Contract data: ");
                Console.Write("Date (DD/MM/YYYY: ");//DIGITE Data
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");  //Valor por hora
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Duration Hour: "); //Duraçao por horas
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and year calculator income(MM/YYYY):");//Entre com mês e ano para calcular o ganho
            string monthAndyear = Console.ReadLine();
            int month = int.Parse(monthAndyear.Substring(0, 2)); //Aqui usamos uma substring para colocar  mês com dois digitos
            int year = int.Parse(monthAndyear.Substring(3));     //Aqui usamos uma substring para colocar ano com três digitos

            Console.WriteLine("Name:"+ worker.Name); //Foi imprimido nome trabalhador
            Console.WriteLine("Department:" + worker.Department.Name);  //nome do departamento
            Console.WriteLine("income for " + monthAndyear + ":" +worker.Income(year,month));//ganho trabalhador mes e ano







        }
    }
}
