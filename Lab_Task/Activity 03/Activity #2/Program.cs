using System;
class Program
{
    static void Main(string[] args)
    {
        testCatch2();
    }

    private static void testCatch2()
    {
        System.IO.StreamWriter ew = null;
        try
        {
            ew = new System.IO.StreamWriter(@"D:\text.txt");
            ew.WriteLine("Hello");
        }
        catch (System.IO.FileNotFoundException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
        catch (System.IO.IOException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
        finally
        {
            ew.Close();
        }
        System.Console.WriteLine(" Done");
    }
}

