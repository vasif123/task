using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkkkkkktask1.Models
{
    class Student
    {
        private string _fullname;
        private string _groupno;
        public int Age;
        
        

        public Student(string fullname,string groupno,int age)
        {
            Fullname = fullname;
            Groupno = groupno;
            Age = age;
        }
        public static bool GroupcheckNo(string groupno)
        {
            bool checker = false;
            if (groupno.Length == 4)
            {

                if (char.IsUpper(groupno[0]))
                {
                    for (int i = 1; i < groupno.Length; i++)
                    {
                        if (char.IsDigit(groupno[i]))
                        {
                            checker = true;
                            return checker;

                        }
                        else
                        {
                            Console.WriteLine("reqem olmalidir!");
                            return checker;
                        }
                    }
                }
                Console.WriteLine("1-ci  herf boyuk olmalidir");
                
                
                
            }
            Console.WriteLine("1 boyuk herf ve 3  ededden ibaret olmalidir");
           
           
           
            return checker;
        }
        public string Groupno
        {
            get => _groupno;

            set
            {
                while (!GroupcheckNo(value))
                {
                    Console.WriteLine("duzgun daxil et");
                    value = Console.ReadLine();
                }
                _groupno = value;
            }
        }

        public static bool FullNamecheck(string fullname)
        {

            bool chech = false;
            foreach (char item in fullname)
            {
                if (char.IsWhiteSpace(item))
                {

                    chech = true;
                    return chech;

                }

            }


            return chech;
        }

        public string Fullname
        {
            get => _fullname;
            set
            {
                while (!FullNamecheck(value))
                {
                    Console.WriteLine("daxil edin");
                    value = Console.ReadLine();
                }
                _fullname = value;
            }
        }
    }
}
