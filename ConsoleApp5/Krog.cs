
using System;

class Krog
{
    private double r;

    // Privzeti konstruktor
    public Krog()
    {
        r = 1;
    }

    // Konstruktor z argumentom
    public Krog(double r)
    {
        this.r = r;
    }

    // Nastavljanje polmera
    public void Nastavi(double r)
    {
        this.r = r;
    }

    // Obseg kroga
    public double Obseg()
    {
        return 2 * Math.PI * r;
    }

    // Ploscina kroga
    public double Ploscina()
    {
        return Math.PI * r * r;
    }
}
