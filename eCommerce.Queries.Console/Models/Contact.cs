using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    [Table("Contatos")]
    public class Contact {
        // Attributes
        [Key]
        public int Id { get; set; }
        [Column("UsuId")]
        [ForeignKey("Usuarios")]
        public int UserId { get; set; }
        [Column("Telefone")]
        public string? Phone { get; set; }
        [Column("Celular")]
        public string? CellPhone { get; set; }

        // Composition
        // [ForeignKey("UsuId")]
        public User? User { get; set; }

        // Constructors
        public Contact() { }

        public Contact(int id, int userId, string? phone, string? cellPhone) {
            Id = id;
            UserId = userId;
            Phone = phone;
            CellPhone = cellPhone;
        }
    }
}
