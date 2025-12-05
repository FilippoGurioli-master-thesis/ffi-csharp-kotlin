using System.Runtime.InteropServices;

public static class KotlinFunctions
{
    [DllImport("simplekotlinlib", CallingConvention = CallingConvention.Cdecl)]
    public static extern int add_ints(int a, int b);
}


public static class Program
{
    public static void Main()
    {
        Console.WriteLine(KotlinFunctions.add_ints(4, 5));
    }
}
