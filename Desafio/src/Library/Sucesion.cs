namespace Library;
public class Sucesion
{
    public void Calculator(int valor)
    {
        int TerminosAmount=0;
        int LongestCadena=0;
        foreach (var value in Enumerable.Range(1, valor).Reverse())
        {
            Console.WriteLine($"---Numero actual: {value} ---");
            int Pasos= 0;
            int Result = value;
            while(Result!=1)
            {
                if(Result%2==0)
                {
                    Result= Result/2;
                    Console.WriteLine($"{Result}");
                    Pasos+=1;
                    
                }
                else
                {
                    Result=(3*Result)+1;
                    Console.WriteLine($"{Result}");
                    Pasos+=1;
                }

            }
            if(Pasos>TerminosAmount)
            {
                LongestCadena=value;
                TerminosAmount=Pasos;
            }
            Pasos=0;
            Console.WriteLine("----------------");
        }
        Console.WriteLine($"La cadena más larga la produce el número {LongestCadena} con {TerminosAmount} terminos");    
    }
}
