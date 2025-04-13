using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    public class StudentBL : PersonBL
    {
        private string program;
        private int year;
        private double fee;

        public StudentBL(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string GetProgram()
        {
            return program;
        }

        public void SetProgram(string program)
        {
            this.program = program;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public double GetFee()
        {
            return fee;
        }
        public void SetFee(double fee)
        {
            this.fee = fee;
        }
        public override string ToString()
        {
            return $"Student: {base.ToString()}, Program: {program}, Year: {year}, Fee: {fee}";
        }
    }
}
