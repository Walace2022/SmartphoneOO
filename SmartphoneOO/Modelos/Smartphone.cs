﻿namespace SmartphoneOO.Modelos;

internal abstract class Smartphone
{
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando ...");
    }

    public void ReceberLigação()
    {
        Console.WriteLine("Recebendo ligação ...");
    }

    public abstract void InstalarAplicativo(string aplicativo);
}
