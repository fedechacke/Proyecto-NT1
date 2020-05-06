using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloApp
{
    class Usuario
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int edad { get; set; }
        private int id { get; set; }
        private List<Autor> autoresFavoritos { get; set; }
        private List<Libro> librosFavoritos { get; set; }
        private List<Resena> resenasFavoritas { get; set; }

        public Usuario() { }
        public Usuario(string nombre, string apellido, int edad, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.id = id;
            this.librosFavoritos = new List<Libro>();
            this.resenasFavoritas = new List<Resena>();
            this.autoresFavoritos = new List<Autor>();
        }
    }
}
