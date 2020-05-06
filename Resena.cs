namespace ModeloApp
{
    internal class Resena
    {
        private string titulo { get; set; }
        private double puntaje { get; set; }
        private string texto { get; set; }
        private string tituloLibro { get; set; }

        public Resena() { }
        public Resena(string titulo, string texto, string tituloLibro)
        {
            this.titulo = titulo;
            this.texto = texto;
            this.tituloLibro = tituloLibro;
            this.puntaje = 0;
        }
    }
}