public class Cat : Animal
{
    public Cat(string name) : base(name){}
    public override void Sound()
    {
        System.Console.WriteLine("Meow");
    }

}