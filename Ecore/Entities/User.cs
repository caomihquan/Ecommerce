
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecore.Entities
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string CreatedId { get ; set; }
        //public DateTimeOffset CreatedAt { get; set; }
        //public string UpdatedId { get; set; }
        //public DateTimeOffset UpdatedAt { get; set; }
    }
}
