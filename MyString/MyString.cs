using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My
{
    public class MyString
    {

       public char[] str;

        public int getLength()
        {
            return str.Length;
        }

        public int Length
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
      
        //перегрузка оператора +
        public static MyString operator +(MyString s1, MyString s2)
        {
            int L = s1.str.Length + s2.str.Length;

            var sumstr = new MyString();

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

        public static bool operator < (MyString s1, MyString s2)
        {
          
            int i = 0;
            for (; i < s1.Length && i < s2.Length; i++)
            {
                if (s1[i] < s2[i]) return true;
                if (s1[i] > s2[i]) return false;
            }
            return i < s2.Length;

        }

        public static bool operator > (MyString s1, MyString s2)
        {
            int i = 0;
            for (; i < s1.Length && i < s2.Length; i++)
            {
                if (s1[i] > s2[i]) return true;
                if (s1[i] < s2[i]) return false;
            }
            return i > s2.Length;
        }


        //Преобразования класса-строка в тип string (и наоборот).
        public static implicit operator string(MyString MyStr)
        {
            int len = MyStr.Length;
            char[] mch = new char[len];
            string chstr = "";
            for (int i = 0; i < MyStr.Length; i++)
            {
                mch[i] = MyStr[i];
            }
            for (int i = 0; i < MyStr.Length; i++)
            {
                chstr = chstr + mch[i];
            }
            return chstr;
        }

        public static implicit operator MyString(string Str)
        {
            MyString p = new MyString(Str.Length);
            p = ToArray(Str.ToCharArray());
            return p;
        }

        public char[] ToArray(MyString MyStr)
        {
            char[] res = new char[MyStr.Length];
            for (int i = 0; i < MyStr.Length; i++)
            {
                res[i] = MyStr.str[i];
            }
            return res;
        }

        public static MyString ToArray(char[] arr)
        {
            int p;
            MyString res = new MyString(arr.Length);
            p = arr.Length;
            for (int i = 0; i < p; i++)
            {
                res.str[i] = arr[i];
            }
            return res;
        }

     
        public MyString Copy(MyString in_str, MyString src_str)
        {
            for (int i = 0; i < in_str.Length; i++)
                in_str[i] = src_str[i];
            return in_str;
        }

        public int FindSymbol(char symbol)
        {
            for (int i = 0; i < Length; i++)
            {
                if (str[i] == symbol)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool StrCmp(MyString str_f, MyString str_s)
        {
            int i = 0;

            for (; str_f[i] == str_s[i] && i < str_f.Length; i++) ;

            return (i == str_f.Length) ? true : false;
        }

        public bool StrCmp(MyString str_f)
        {
            return ((str_f is MyString && this == (MyString)str_f));
        }

        public MyString Remove(MyString obj, int StartIndex)
        {
            MyString chstr = new MyString();
            for(int i = 0; i < obj.Length; i++)
            {
                if (i == StartIndex)
                    break;
                else { chstr[i] = obj[i]; }
            }
            return chstr;
        }

        public MyString Remove(MyString obj, int StartIndex, int Count)
        {
            MyString chstr = new MyString();
            MyString temp = new MyString();

            for (int i = 0; i < obj.Length; i++)
            {
                if (i != StartIndex - 1)
                {
                    chstr[i] = obj[i];
                }
                else
                {
                    int k = 0;
                    for (int j = StartIndex + Count - 1; j < obj.Length; j++)
                    {
                        temp[k] = obj[j];
                        k++;
                    }
                }
            }
            int k1 = 0;
            for (int j = StartIndex - 1; j < obj.Length - Count; j++)
            {
                chstr[j] = temp[k1];
                k1++;
            }
            return chstr;
        }

        public MyString Substring(MyString obj, int StartIndex)
        {
            MyString chstr = new MyString();
            int j = 0;
            for (int i = StartIndex - 1; i < obj.Length; i++)
            {
                chstr[j] = obj[i];
                j++;
            }
            return chstr;
        }

        public MyString Substring(MyString obj, int StartIndex, int Count)
        {
            MyString chstr = new MyString();
            int j = 0;
            for (int i = StartIndex - 1; i < StartIndex + Count - 1; i++)
            {
                chstr[j] = obj[i];
                j++;
            }
            return chstr;
        }
   

        public MyString Replace(MyString Str, char Old,  char New) 
        {
          
            for (int index = 0; index < Str[index]; index++)
                if (Str[index] == Old) Str[index] = New;
            return Str;
        }

        public MyString Concat(MyString obj, MyString obj1)
        {
            int count1 = 0; 
            while (obj[count1] != 0)
            {
                count1++; 
            }
            int count2 = 0; 
            while (obj1[count2] != 0)
            {  
                obj[count1] = obj1[count2];
                count1++;
                count2++;
            }
            return obj;
        }

        public MyString Concat(MyString obj, MyString obj2, MyString obj3)
        {
            int count1 = 0; 
            while (obj[count1] != 0)
            {
                count1++; 
            }

            int count2 = 0; 
            while (obj2[count2] != 0)
            {   
                obj[count1] = obj2[count2];
                count1++;
                count2++;
            }
            int count3 = 0;
            while (obj3[count3] != 0)
            {   
                obj[count1] = obj3[count3];
                count1++;
                count2++;
                count3++;
            }
            return obj;
        }

        public MyString(int init_size)
        {
            str = new char[init_size];
        }

        public MyString()
        {
            str = new char[256];
        }

        public MyString(String incomingString)
        {
            str = new char[incomingString.Length];
            for (int i = 0; i < incomingString.Length; i++)
            {
                str[i] = incomingString[i];
            }
        }
    }
}
