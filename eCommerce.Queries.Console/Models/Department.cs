using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    [Table("Departamentos")]
    public class Department {
        // Attributes
        [Key]
        public int Id { get; set; }
        [Column("Nome")]
        public string Name { get; set; } = string.Empty;

        // Composition
        public virtual ICollection<User>? Users { get; set; }

        // Constuctors
        public Department() { }

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
