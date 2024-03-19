using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sln_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //복합대입연산자
             int output = 50;
             output += 50; // output = output + 50;
             Console.WriteLine(output);
             output /= 5; // output = output / 5;
             Console.WriteLine(output);

             //+ : 문자열 연결 연산자
             string input = "Hello";
             input += " World!";
             Console.WriteLine(input); */

            // 증감 연산자

            /* int number1 = 10;
            number1++;
            Console.WriteLine(number1); // 11
            number1--;
            Console.WriteLine(number1); // 10
            ++number1;
            Console.WriteLine(number1); // 11
            --number1;
            Console.WriteLine(number1); // 10 */

            /* int number2 = 20;
            Console.WriteLine(number2); //20
            Console.WriteLine(number2++); //20 -> 21  20출력후 그 뒤에 1 증가
            Console.WriteLine(number2--); //21 -> 20
            Console.WriteLine(++number2); //21
            Console.WriteLine(--number2); //20 

            int number3 = 30;
            Console.WriteLine(number3); // 30
            number3++;
            number3++;
            Console.WriteLine(number3); // 32
            number3--;
            number3--;
            Console.WriteLine(number3); // 30 */

            /* // 자료형
            int _int = 275;
            long _long = 522731033265;
            float _float = 52.273f; // f 넣어야함
            double _double = 52.273; // 실수값 기본
            char _char = '글'; // 구조체와 클래스의 차이 구조체: 메모리공간 미리 준비 / 클래스: 설계도
            string _string = "문자열"; // 

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_string.GetType()); */

            //var 키워드
            var numberA = 100;
            var numberB = 100.123f;
            var numberC = 100.123;
        }
    }
}
