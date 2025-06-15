using System;
using System.Collections.Generic;

namespace CalculadoraRedes.Client.Models
{
    [Serializable]
    public class SplitterSeleccionado
    {
        public string Valor { get; set; } = "0";
    }

    [Serializable]
    public class BloqueAtenuacion
    {
        public List<SplitterSeleccionado> Splitters { get; set; } = new() { new SplitterSeleccionado() };
        public int Fusiones { get; set; } = 0;
        public int Acopladores { get; set; } = 0;
        public double Longitud { get; set; } = 0;
    }
}
