using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.BL;


namespace LabManual_5_Task1_.BL
{
    class Student
    {
        public string Name;
        public int Age;
        public float FscMarks;
        public float EcatMarks;
        public float Merit;
        public string Roll_no;
        public string degreeProgram;
        public DegreeProgram regDegree;
        public List<Subject> regSubject;
        public List<Subject> preferences;

        public Student(string name, int age, float fscMarks, float ecatMarks, float merit)
        {
            Name = name;
            Age = age;
            FscMarks = fscMarks;
            EcatMarks = ecatMarks;
            Merit = merit;
            regSubject = new List<Subject>();
            preferences = new List<Subject>();
        }
        public Student(string name , int age , float fscMarks, float ecatMarks , string degreeProgram)
        {
            Name = name;
            Age = age;
            FscMarks = fscMarks;
            EcatMarks = ecatMarks;
            this.degreeProgram = degreeProgram;
         }

        public static float CalculateMerit(float fscMarks, float ecatMarks)
        {
            return (((fscMarks / 1100) * .45F) + ((ecatMarks / 400) * .55F)) * 100;
        }

        public static int GetTotalCreditHours(List<Subject> subjects)
        {
            int totalCreditHours = 0;
            foreach (Subject subject in subjects)
            {
                totalCreditHours = totalCreditHours + subject.creditHours;
            }
            return totalCreditHours;
        }
        public float calculateFee()
        {
            float fee = 0;
            if (regDegree != null)
            {
                foreach (Subject s in regSubject)
                {
                    fee = fee + s.subjectFee;
                }
            }
            return fee;
        }



    }
}
