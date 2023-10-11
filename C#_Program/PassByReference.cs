using System;
namespace MyFirstProject
{
     class Program
    {
        static void Main(string[] args)
        {
         Employee emp1 = new Employee();
         emp1.EmpId = 1;
         emp1.Name = "Shivani";
         
         UpdateName(emp1);
         Console.WriteLine($"Emp1 Name = {emp1.Name}");
         Console.ReadKey();
        }
        
        public static void UpdateName(Employee emp2){
            emp2.Name = "Smith";
            Console.WriteLine($"Emp2 Name = {emp2.Name}");
        }
    }
    
    public class Employee{
        public int EmpId;
        public string Name;
    }
}