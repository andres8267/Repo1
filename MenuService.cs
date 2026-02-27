using System.Collections.Generic;

namespace Restaurante1
{
    public class MenuService
    {
        // 🔹 Instancia única (Singleton)
        private static readonly MenuService _instancia = new MenuService();

        public static MenuService Instancia
        {
            get { return _instancia; }
        }

        // Constructor privado
        private MenuService() { }

        public List<Producto> ObtenerMenu()
        {
            return new List<Producto>
            {
                new Producto("Hamburguesa", 5.00m),
                new Producto("Cerveza", 3.00m),
                new Producto("Gaseosa", 2.50m),
                new Producto("Ensalada", 4.00m),
                new Producto("Salchichas", 3.50m),
                new Producto("Refresco", 2.00m),
                new Producto("Sopa", 3.00m),
                new Producto("Postre", 4.50m)
            };
        }
    }
}