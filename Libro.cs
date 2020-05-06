using System.Collections.Generic;

namespace ModeloApp
{
    internal class Libro
    {
        private string titulo { get; set; }
        private int id { get; set; }
        private string isbn { get; set; }
        private Resena resena { get; set; }
        private Autor autor { get; set; }

        public Libro() { }
        public Libro(string titulo, int id, string isbn, Autor autor)
        {
            this.titulo = titulo;
            this.id = id;
            this.isbn = isbn;
            this.autor = autor;
        }

    }
}