using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RYAN.Models;

public class Carrinho {
    public int Id {get; set;}
    [ForeignKey("Usuario")]
    public int UsuarioId {get; set;}
    public virtual Usuario Usuario {get; set;}
    public virtual ICollection<Produto> Produtos {get; set;}

}
