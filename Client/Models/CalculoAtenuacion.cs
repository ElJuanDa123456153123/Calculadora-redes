using System;

namespace CalculadoraRedes.Client.Models
{
    [Serializable]
    public class CalculoAtenuacion
    {
        public double totalSplitters { get; set; }
        public double Fusiones { get; set; }
        public double Acopladores { get; set; }
        public double LongitudCable { get; set; }

        public double AtenuacionFusiones { get; set; }
        public double AtenuacionAcopladores { get; set; }
        public double AtenuacionFibra { get; set; }

        public double AtenuacionTotal { get; set; }
        public double PotenciaRecibida { get; set; }
    }
}
