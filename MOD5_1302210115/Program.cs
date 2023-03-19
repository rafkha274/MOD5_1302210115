class Program
{
    void Main(string[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("NIM praktikan"); // ganti dengan nim praktikan
        data.PrintData();
    }
}

class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
class program
{
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Muhammad Rafkha Prima Aditya");
    }


}
class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

