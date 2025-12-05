using System.Runtime.InteropServices;

public static class KotlinFunctions
{
    [DllImport("simplekotlinlib", EntryPoint = "add_ints", CallingConvention = CallingConvention.Cdecl)]
    public static extern int AddInts(int a, int b);
}


public static class Program
{
    public static void Main()
    {
        Console.WriteLine(KotlinFunctions.AddInts(4, 5));
    }
}
