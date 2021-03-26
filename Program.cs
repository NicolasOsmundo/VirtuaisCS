using System;
public class ClasseBase
{
    public void Metodo()
    {
        Console.WriteLine("Método ClasseBase");
    }
}
    public class Derivada : ClasseBase
    {
        public void Metodo()
        {
            Console.WriteLine("Método Derivado");

        }
    }
public class Program
{
    static void Main(string[] args)
    {
        ClasseBase a = new ClasseBase();
        a.Metodo();
        Derivada b = new Derivada();
        b.Metodo();
        ClasseBase c = new Derivada();
        c.Metodo();
        Console.Read();
    }
}
    
