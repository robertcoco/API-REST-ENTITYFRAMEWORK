namespace projectEntity.Models
{
    public class Tarea
    {
        public Guid tareaId { get; set; }

        public Guid categoriaId { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public Prioridad prioridad { get; set; }

        public Categoria Categoria { get; set; }

        public DateTime Fechacreada { get; set; }

        public string Resumen { get; set; }
    }

    public enum Prioridad
    {
        bajo,
        medio,
        alto

    }
}