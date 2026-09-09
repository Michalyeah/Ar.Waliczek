class Program
{ 

    public static double Ek(double m, double v)
    {
        return (m * Math.Pow(v,2)) / 2;
    }
    public static double Ep(double m, double h)
    {
        int g = 10;
        return (m * g * h);

    }
    public static double EM(double m, double v, double h)
    {
        
        return Ek(m,v) + Ep(m,h);
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("Energia kinetyczna wynosi = " + Ek(10, 5));
        Console.WriteLine("Energia kinetyczna wynosi = " + Ep(7, 6));
        
    }
}

//Wynzacz Ek = mv2 /2 , Ep = mgh, EM = Ek + Ep 