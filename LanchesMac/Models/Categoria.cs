using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [Display(Name = "Categoria")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é {1} caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        public string CategoriaNome { get; set; }
        [Display(Name = "Descrição da Categoria")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é {1} caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
