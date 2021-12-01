using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SuportDefcom.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo Obrigátorio")]
        public string? Title { get; set; }

        [DisplayName("Concluído")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Última Atualização")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [DisplayName("Usuário")]
        public string? User { get; set; }

        [DisplayName("Descrição")]
        public string? Description { get; set; }


    }
}
