using System;

class Cliente
{
    private string nombre;
    private decimal saldo;

    public Cliente(string nombre, decimal saldoInicial)
    {
        this.nombre = nombre;
        saldo = saldoInicial;
    }

    public void RealizarDeposito(decimal cantidad)
    {
        saldo += cantidad;
        Console.WriteLine($"{nombre} ha realizado un depósito de {cantidad}.");
    }

    public void RealizarExtraccion(decimal cantidad)
    {
        if (cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine($"{nombre} ha realizado una extracción de {cantidad}.");
        }
        else
        {
            Console.WriteLine($"{nombre} no tiene saldo suficiente para realizar la extracción de {cantidad}.");
        }
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}

class Banco
{
    private Cliente cliente1;
    private Cliente cliente2;
    private Cliente cliente3;

    public Banco()
    {
        cliente1 = new Cliente("Cliente1", 1000);
        cliente2 = new Cliente("Cliente2", 1500);
        cliente3 = new Cliente("Cliente3", 2000);
    }

    public void RealizarOperaciones()
    {
        cliente1.RealizarDeposito(500);
        cliente2.RealizarExtraccion(200);
        cliente3.RealizarDeposito(1000);
        cliente1.RealizarExtraccion(700);
    }

    public void CalcularTotalDepositos()
    {
        decimal totalDepositos = cliente1.ObtenerSaldo() + cliente2.ObtenerSaldo() + cliente3.ObtenerSaldo();
        Console.WriteLine($"\nTotal de dinero depositado al final del día: {totalDepositos}");
    }
}

class Program
{
    static void Main()
    {
        Banco miBanco = new Banco();
        miBanco.RealizarOperaciones();
        miBanco.CalcularTotalDepositos();
    }
}


