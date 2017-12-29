using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My;

namespace ConsoleApp7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyString p1 = new MyString();
            p1 = "1";
            MyString p2 = new MyString("dhjaskjdaskjas");
            MyString p3 = new MyString("daskldhjaskjdaskjas");
            //p2 = "4525246";
            //char p2 = '4';
            //char p3 = '1';
            MyString s3 = new MyString("bcdfj");
            MyString s4 = new MyString("cdfjh");
            //char p5 = '1';
            char[] line = { '2' };
            string q = p1;
           // Console.WriteLine(q);
            MyString p = new MyString();

            Console.WriteLine(s3 < s4);
            //Console.WriteLine(p1);
            //Console.WriteLine(p.Remove(p1, 2, 2));
            //Console.WriteLine(p.StrCmp(p1, p2) + "\n");
            //Console.WriteLine(p.Replace(p1, '3', '1'));
            //Console.WriteLine(p.Substring(p1, 2, 4));
            //Console.WriteLine(p.StrCmp(p));
            //Console.WriteLine(p.Concat(p1, p2, p3));
            //Console.WriteLine(p1.FindSymbol(p5));
        }
    }
}

