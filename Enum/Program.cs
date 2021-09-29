using System;

namespace Enum
{
    class Program
    {
        /*
         enum : 상수 숫자들을 보다 의미있는 단어들로 표현
         */
        enum EnumLanguage
        {
            Charp, // 0
            Java, // 1
            JavaScript = 10,
            Go = 20
        }
        static void Main(string[] args)
        {
            #region enum
            EnumLanguage pr = EnumLanguage.Java;

            Console.WriteLine(EnumLanguage.Charp); // Default string type

            int value = (int)EnumLanguage.JavaScript; // int type 변환
            Console.WriteLine(value);
            #endregion enum




        }


    }
}
