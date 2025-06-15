using System.Collections.Generic;
using CalculadoraRedes.Client.Models;

namespace CalculadoraRedes.Client.Services
{
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
}
