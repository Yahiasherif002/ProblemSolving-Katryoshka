using System;
internal class Program
{
    private static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split();
        long eyes = long.Parse(input[0]);
        long mouth = long.Parse(input[1]);
        long body = long.Parse(input[2]);
        long  counter = 0;              // 90  24    89
        long minVlue= Math.Min( Math.Min(eyes,mouth),body);// using one eye, one mouth, and one body.
                             //minVlue = 24
        counter +=minVlue;//=24
        eyes-=minVlue;//=66
        mouth-=minVlue; //0
        body-=minVlue;//65
                          //33      65
        minVlue = Math.Min(eyes/2, body);// using two eyes, and one body.
                    // minVlue = 33;
        counter +=minVlue; // = 24+33= 57
        Console.WriteLine( counter);






    }
}