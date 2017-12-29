using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class MyString1
    {
        private char[] str;

        //длина строки
        public int Lenght
        {
            get
            {
                return str.Length;
            }
            set
            {
                char[] temp = new char[value];
                if (value > str.Length)
                {
                    value = str.Length;
                }
                for (int i = 0; i < value; i++)
                {
                    temp[i] = str[i];
                    str = temp;
                }
            }
        }

        //индекс элемента массива
        public char this[int index]
        {
            get
            {
                return str[index];
            }
            set
            {
                str[index] = value;
            }
        }
        //перегрузка оператора ==
        public static bool operator ==(MyString1 s1, MyString1 s2)
        {
            if (s1 == s2)
            {
                return true;
            }
            if (s1.str.Length != s2.str.Length)
            {
                return false;
            }
            for (int i = 0; i < s1.str.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }
            return true;
        }
        //перегрузка оператора !=
        public static bool operator !=(MyString1 s1, MyString1 s2)
        {
            return !(s1 == s2);
        }

        //перегрузка оператора +
        public static MyString1 operator +(MyString1 s1, MyString1 s2)
        {
            int L = s1.str.Length + s2.str.Length;

            var sumstr = new MyString1(L);

            for (int i = 0; i < s1.str.Length; i++)
            {
                sumstr[i] = s1[i];
            }
            for (int i = 0; i < s2.str.Length; i++)
            {
                sumstr[s1.str.Length + i] = s2[i];
            }
            return sumstr;
        }

        //Преобразования класса-строка в тип string (и наоборот).
        public static explicit operator String(MyString1 MyStr)
        {
            return new String(ToArray(MyStr));
        }

        public static explicit operator MyString1(String Str)
        {
            return new MyString1(ToArray(Str.ToCharArray()));
        }



        public bool Equals1(Object obj)
        {
            return obj is MyString1 && this == (MyString1)obj;
        }

        public bool Equals1(Object obj, Object obj1)
        {
            return ((obj is MyString1 && this == (MyString1)obj) && (obj1 is MyString1 && this == (MyString1)obj1));
        }

        //метод ToArray
        public static char[] ToArray(MyString1 MyStr)
        {
            char[] res = new char[MyStr.Lenght];
            for (int i = 0; i < MyStr.Lenght; i++)
            {
                res[i] = MyStr.str[i];
            }
            return res;
        }

        public static MyString1 ToArray(char[] arr)
        {
            MyString1 res = new MyString1(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                res.str[i] = arr[i];
            }
            return res;
        }


        public int Find(MyString1 findstr)
        {
            if (Lenght < findstr.Lenght)
            {
                return -1;
            }
            for (int i = 0; i < Lenght - findstr.Lenght; i++)
            {
                for (int j = 0; j < findstr.Lenght; j++)
                {
                    if (str[i + j] != findstr[j]) { goto P1; }
                }
                return i;
                P1:;
            }
            return -1;
        }

        public int FindSymbol(char symbol)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (str[i] == symbol)
                {
                    return i;
                }
            }
            return -1;
        }

        public MyString1(MyString1 previousMyString)
        {
            if (this == previousMyString)
            {
                throw new ArgumentException("Нельзя копировать строку саму в себя!");
            }
            str = new char[previousMyString.str.Length];
            for (int i = 0; i < previousMyString.str.Length; i++)
            {
                str[i] = previousMyString.str[i];
            }
        }
        
    public MyString1(int init_size)
        {
            str = new char[init_size];
        }

    public MyString1(String incomingString)
    {
            str = new char[str.Length];
            for (int i = 0; i < incomingString.Length; i++)
            {
                str[i] = incomingString[i];
            }
        }


}
}
