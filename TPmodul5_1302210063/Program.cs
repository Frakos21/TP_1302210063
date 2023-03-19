internal class Program
{
    private static void Main(string[] args)
    {
        DataGeneric dataGeneric = new DataGeneric("1302210063");
        dataGeneric.printData();

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