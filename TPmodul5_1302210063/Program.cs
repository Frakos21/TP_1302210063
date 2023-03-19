internal class program
{
    private static void Main(string[] args)
    {
        HelloGeneric helloGeneric = new HelloGeneric();
        helloGeneric.SapaUser("Fathur Rahman Kosasih");
    }
}
class HelloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine("Hello " + username);
    }
}
