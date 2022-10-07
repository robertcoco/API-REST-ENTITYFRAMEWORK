using System.Text.Json.Serialization;

namespace projectEntity.Models
{
    public class Categoria 
    {
        public Guid categoriaId { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Peso { get; set; }

        [JsonIgnore]
        public virtual ICollection<Tarea> Tareas { get; set; }
    }

}
