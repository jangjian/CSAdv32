﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Expando;
using System.Text;
using System.Threading.Tasks;
namespace CSAdv32
{
    class Wanted<T>  // Generic 
    {
        public T Value;
        public Wanted(T value)
        {
            Value = value;
        }
    }
    class Needed<T, U> // Generic
    {
        public T Value1;
        public U Value2;
        public Needed(T value1, U value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
    class SpecialNeeded<T, U> // Generic
        where T : IComparable
        where U : IComparable, IDisposable
    {
        public T Value1;
        public U Value2;
        public SpecialNeeded(T value1, U value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
    class SquareCalculator
    {
        public int this[int i] // Indexer
        {
            get { return i * i; }
        }
    }
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;
            //public string testB = "init"; // 구조체 내 변수는 선언과 동시에 초기화 불가능

            //public Point() { }  //구조체 -> 기본생성자 정의 불가능

            public Point(int x, int y) // 구조체 생성자 -> 모든 변수 초기화 해주어야 함
            {
                this.x = x;
                this.y = y;
                this.testA = "init";
                this.testB = "init";
            }
            public Point(int x, int y, string t) // 생성자 오버로딩 가능
            {
                this.x = x;
                this.y = y;
                this.testA = t;
                this.testB = t;
            }
        }

        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)








          Expand Down



        {
            rx = x + vx;
            ry = y + vy;
        }
        static void Main(string[] args)
        {
            Wanted<int> wantedInt = new Wanted<int>(65535);
            Wanted<string> wantedString = new Wanted<string>("Hello, World!");
            Wanted<double> wantedDouble = new Wanted<double>(3.14159);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedDouble.Value);
            SquareCalculator s = new SquareCalculator();
            Console.WriteLine(s[256]);
            Console.Write("숫자 입력: ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자: " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요." + output);
            }
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재좌표 x: {0}, y: {1}", x, y);
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음좌표 x: {0}, y: {1}", x, y);
            // Point 구조체 실습
            Point point;   // 구조체 변수 선언. 8바이트 잡힘.
            point.x = 10;  // 구조체 변수는 반드시 초기화 해야함.(컴파일 에러)
            point.y = 10;
            Console.WriteLine("point.x: {0}, point.y: {1}", point.x, point.y);
        }
    }
}