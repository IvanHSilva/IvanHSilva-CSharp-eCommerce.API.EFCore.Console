using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    [Table("Enderecos")]
    public class Address {
        // Attributes
        [Key]
        public int Id { get; set; }
        [Column("UsuId")]
        public int UserId { get; set; }
        [Column("Descricao")]
        public string? Description { get; set; }
        [Column("Endereco")]
        public string Street { get; set; } = string.Empty;
        [Column("Numero")]
        public string Number { get; set; } = string.Empty;
        [Column("Complemento")]
        public string? Comp { get; set; }
        [Column("Bairro")]
        public string District { get; set; } = string.Empty;
        [Column("Cidade")]
        public string City { get; set; } = string.Empty;
        [Column("Estado")]
        public string State { get; set; } = string.Empty;
        [Column("CEP")]
        public string ZipCode { get; set; } = string.Empty;

        // Composition
        public User? User { get; set; }

        // Constructors
        public Address() {}

        public Address(int id, int userId, string? description,
            string street, string number, string? comp, string district,
            string city, string state, string zipCode) {
            Id = id;
            UserId = userId;
            Description = description;
            Street = street;
            Number = number;
            Comp = comp;
            District = district;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
