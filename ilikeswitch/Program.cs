using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilikeswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학년을 입력하세요: ");
            int level = int.Parse(Console.ReadLine());
            int score = 0;
            switch (level)
            {
                case 1:
                    score = 12;
                    break;
                case 2:
                case 4:
                    score = 18;
                    break;
                case 3:
                    score = 10;
                    break;
            }
            Console.WriteLine("수강해야 하는 전공 학점: " + score + "학점");
        }
    }
}
