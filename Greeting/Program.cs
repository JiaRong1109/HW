﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            member.Name = "Allen";
            string greeting = member.Greet("Hello"); // Hello, Allen
            Console.WriteLine(greeting);
            Member member2 = new Member();
            string greeting2 = member2.Greet("Hello"); // Hello
            Console.WriteLine(greeting2);
            Console.ReadKey();

        }
    }

    public class Member
    {
        public string Name { get; set; }

        /// <summary>
        /// 傳回 'Hello, Allen'
        /// 如果 Name 沒有值, 傳回 'Hello'
        /// </summary>
        /// <param name="greeting"></param>
        /// <returns></returns>
        public string Greet(string greeting)
        {
            string result = "";
            if (Name== null)
            {
                result = greeting;
            }
            else
            {
                result = Name+greeting;
            }
            return result;
        }

    }
}
