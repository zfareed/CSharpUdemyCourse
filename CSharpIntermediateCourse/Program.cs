
namespace CSharpIntermediateCourse
{
    public class Parent
    {
        public virtual void Function()
        {
            System.Console.WriteLine("Hello how are you?");
        }
    }


    public class Child : Parent
    {
        public override void Function()
           
        {
            System.Console.WriteLine("Hello! Brother how are you");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Parent obj = new Parent();
            obj.Function();
            Child obj1 = new Child();
            obj1.Function();


        }
    }
}
