using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloApp
{
    class Autor
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int id { get; set; }
        private List<int> librosXId { get; set; }

        public Autor() { }
        public Autor(string nombre, string apellido, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
            this.librosXId = new List<int>();
        }
    }
}
