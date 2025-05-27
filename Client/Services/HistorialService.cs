using System.Collections.Generic;

namespace CalculadoraRedes.Client.Services;
public class CalculoAtenuacion
{
    public double totalSplitters { get; set; }
    public int Fusiones { get; set; }
    public double AtenuacionFusiones => Fusiones * 0.03;
    public int Acopladores { get; set; }
    public double AtenuacionAcopladores => Acopladores * 0.5;
    public double LongitudCable { get; set; }
    public double AtenuacionFibra => (LongitudCable / 1000) * 0.2;
    public double AtenuacionTotal { get; set; }
    public double PotenciaRecibida { get; set; }
}

public class HistorialService
{
    public List<CalculoAtenuacion> Historial { get; private set; } = new();

    public void Agregar(CalculoAtenuacion calculo)
    {
        Historial.Add(calculo);
    }

    public void Limpiar()
    {
        Historial.Clear();
    }
    public void Eliminar(int index)
    {
    if (index >= 0 && index < Historial.Count)
    {
        Historial.RemoveAt(index);
    }
    }

}
