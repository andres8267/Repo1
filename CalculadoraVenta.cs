using System;
using System.Collections.Generic;

namespace Restaurante1
{
    public class CalculadoraVenta
    {
        // 🔹 Singleton (igual que MenuService)
        private static readonly CalculadoraVenta _instancia = new CalculadoraVenta();

        public static CalculadoraVenta Instancia
        {
            get { return _instancia; }
        }

        // 🔹 Constructor privado
        private CalculadoraVenta() { }

        // 🔹 Evento (Observer)
        public event Action<decimal, decimal, decimal> TotalesActualizados;

        private const decimal IMPUESTO = 0.16m;

        public void ProcesarVenta(Dictionary<Producto, int> productos)
        {
            decimal subtotal = 0;

            foreach (var item in productos)
            {
                subtotal += item.Key.Precio * item.Value;
            }

            decimal impuesto = subtotal * IMPUESTO;
            decimal total = subtotal + impuesto;

            // 🔹 Notificamos al observador
            TotalesActualizados?.Invoke(subtotal, impuesto, total);
        }
    }
}