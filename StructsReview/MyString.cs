using System;
using System.Collections.Generic;
using System.Text;

namespace IndexatorsReview
{
    class MyString
    {
        private readonly char[] content;

        public MyString(char[] input)
        {
            content = input; 
        }

        public void ConsoleDisplay()
        {
            for (int i = 0; i < content.Length; i++)
                Console.Write(content[i]);

            Console.WriteLine();
        }

        public char this[int index]
        {
            get
            {
                if (index >=0 && index < content.Length)
                  return content[index];

                return ' ';
            }          
        }

        public int Length { get { return content.Length;  } }


        public MyString Concat(char[] str)
        {
            char[] newArray = new char[Length + str.Length];

            for (int i = 0; i < Length; i++)
            {
                newArray[i] = content[i];
            }

            for (int j=Length+1, i =0; j<Length + str.Length; j++, i++)
                newArray[j] = str[i];

            return new MyString(newArray);
        }

    }
}
