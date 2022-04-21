using homeworkkkkkktask1.Models;
using System;

namespace homeworkkkkkktask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad soyadi daxil edin");
            string fullname = Console.ReadLine();
            Console.WriteLine("Group nomresini daxil edin");
            string groupno = Console.ReadLine();
            Console.WriteLine("YAwinizi dasxil edin");
            int age = int.Parse(Console.ReadLine());

            Student stu1 = new Student(fullname,groupno,age);

        }
    }
}