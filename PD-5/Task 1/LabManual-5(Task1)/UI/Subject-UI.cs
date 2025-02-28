using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.BL;
using LabManual_5_Task1_.DL;

namespace LabManual_5_Task1_.UI
{
    class Subject_UI
    {
        

        public static Subject InputforSubject()
        {
            string code;
            int subjectFee;
            int creditHours;
            string subjectType;
            Console.WriteLine("Enter Subject Code: ");
            code = Console.ReadLine();
            Console.WriteLine("Enter Subject Fee: ");
            subjectFee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Credit Hours: ");
            creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Type: ");
            subjectType = Console.ReadLine();
            Subject sub = new Subject(code, subjectFee, creditHours, subjectType);
            return sub;
        }

        public static void registerSubjects(Student s)
        {
            Console.WriteLine("Enter the number of subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Subject Code ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.code && !(s.regSubject.Contains(sub)))
                    {
                        if (s.regSubject.Sum(subject => subject.creditHours) + sub.creditHours <= 18)
                        {
                            s.regSubject.Add(sub);
                            Console.WriteLine("Subject registered successfully");
                        }
                        else
                        {
                            Console.WriteLine("Credit hours exceeded");
                        }
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter valid Course");
                    i--;
                }
            }
        }


    }
}
