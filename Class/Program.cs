using System;

namespace Class
{
    class Test
    {
        // 생성자
        public Test()
        {
            this.City = "서울숲";
        }

        // 필드
        public string Name = string.Empty;
        public string City = string.Empty;
        
        // 메서드
        public void Method(int a, int b) 
        {
            Console.WriteLine(String.Format("이름 : {0} // 나이 : {1} // 도시 : {2}" , this.Name , a+b , this.City));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of processors " +
                "on this computer is {0}.",
                Environment.ProcessorCount);
        }
    }
}
