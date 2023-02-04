using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //변수 선언
            int n;
            string str;
            //배열
            string[] Foods = new string[4] { "떡볶이", "김밥" , "만두" , "튀김" };
            //입/출력
            Console.Write("1.떡볶이 2.김밥 3.만두 4.튀김 중에 먹고 싶은 것의 번호는 입력 : ");
            str = Console.ReadLine();
            //음식
            n = Convert.ToInt32(str);
            n -= 1;
            //먹은 음식 출력
            Foods[n] = "먹은 음식은 비어있다.";
            Console.WriteLine("1.{0} 2.{1} 3.{2} 4.{3}", Foods[0], Foods[1], Foods[2], Foods[3]);
        }
    }
}
