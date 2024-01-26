using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWeb.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Column("cadastroId")]
        [Display(Name ="Numero Cadastro")]
        public int cadastroId { get; set; }

        [Column("enderecoId")]
        [Display(Name = "Endereco Cadastro")]
        public int EnderecoId { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column("dataNasc")]
        [Display(Name = "Data Nascimento")]
        public DateTime dataNasc { get; set; }

        [Column("telefone")]
        [Display(Name = "telefone")]
        public string telefone { get; set; }
    }
}
