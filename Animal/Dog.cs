public class Dog : Animal
{
    public Dog (string name) : base(name){}
    public override void Sound()
    {
        System.Console.WriteLine("Woof");
        System.Console.WriteLine("Woooof");
    }
}