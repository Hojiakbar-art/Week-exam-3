public class Bigdog : Animal
{
    public Bigdog (string name) : base (name){}
    public override void Sound()
    {
        System.Console.WriteLine("Woow");
        System.Console.WriteLine("Woooow");
        System.Console.WriteLine("Woooooow");
    }
}