﻿namespace SmartphoneOO.Modelos;

internal class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando aplicativo {aplicativo} no Nokia.");
    }
}
