using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    [Table("Usuarios")]
    //[Index(nameof(Name), IsUnique = true, Name = "IDX_Name")]
    public class User {
        // Attributes
        [Key]
        public int Id { get; set; }
        [Column("Nome"), Required, MaxLength(70)]
        public string Name { get; set; } = string.Empty;
        [Required, MaxLength(100)]
        public string EMail { get; set; } = string.Empty;
        [Column("Senha"), Required, MaxLength(100)]
        public string Password { get; set; } = string.Empty;
        [Required, MaxLength(1)]
        [Column("Sexo")]
        public string? Gender { get; set; }
        [MaxLength(12)]
        public string? RG { get; set; }
        [MaxLength(14)]
        public string? CPF { get; set; }
        [MaxLength(70)]
        [Column("Filiacao")]
        public string? Filiation { get; set; }
        [MaxLength(1)]
        [Column("Situacao")]
        public string? Situation { get; set; }
        [Column("DataCad")]
        public DateTime RegDate { get; set; }

        // Composition
        public Contact? Contact { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Department>? Departments { get; set; }

        // Constructors
        public User() { }

        public User(int id, string name, string eMail, string? gender,
            string? rg, string? cpf, string? filiation, string? situation,
            DateTime regDate) {
            Id = id;
            Name = name;
            EMail = eMail;
            Gender = gender;
            RG = rg;
            CPF = cpf;
            Filiation = filiation;
            Situation = situation;
            RegDate = regDate;
        }
    }
}
