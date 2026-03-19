using System;
using System.Collections.Generic;
using System.Text;

namespace IndexatorsReview
{
    class MyClass : IInterface
    {
        private string[] words;

        public MyClass()
        {
            words = new string[5];
        }

        public string this[int index]
        {
            get
            {
                return words[index];
            }
            set
            {
                words[index] = value;   
            }
        }

        public string Name 
        {
            get
            {
                if (field is not null)
                    return field;

                return string.Empty;
            }
            set 
            {
                if (field != value)
                    field = value;  
            }
        }
    }
}
