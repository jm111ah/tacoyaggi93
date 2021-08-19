using System;

namespace Iinterface
{
    interface ISource // 인터페이스 생성
    {
        int GetResult();
    }

    class Source : ISource // 인터페이스 상속
    {
        public int GetResult() // 상속 받은 클래스의 메서드의 접근제한자는 무조건 public 그리고 인터페이스의 메서드의 이름과 동일해야함
        {
            return 10;
        }
    }

    class Target : ISource // 인터페이스 상속
    {
        public int GetResult() // 상속 받은 클래스의 메서드의 접근제한자는 무조건 public 그리고 인터페이스의 메서드의 이름과 동일해야함
        {
            return 20;
        }
        public void Do(ISource obj)
        {
            Console.WriteLine(obj.GetResult());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Source so = new Source();
            Target target = new Target();
            target.Do(so);
            target.Do(target);

            ISource aa = new Target();
            ISource bb = new Source();
            Console.WriteLine(aa.GetResult());
            Console.WriteLine(bb.GetResult());
        }
    }
}