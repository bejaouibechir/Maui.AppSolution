using SQLite;

namespace HRProjet.MAUI.MVVM.Models
{
    [Table("Employees")]
    public class Employee
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public override string ToString() => $"{Id} {Name} {Salary}";
    }
}
