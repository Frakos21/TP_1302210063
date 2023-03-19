
﻿internal class program
{
    private static void Main(string[] args)
    {
        HelloGeneric helloGeneric = new HelloGeneric();
        helloGeneric.SapaUser("Fathur Rahman Kosasih");

        DataGeneric dataGeneric = new DataGeneric("1302210063");
        dataGeneric.printData();

    }
}
class HelloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine("Hello " + username);
    }
}
internal class DataGeneric
{
    string t;
    public DataGeneric(string t)
    {
        this.t = t;
    }
    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah : " + t);
    }
}
