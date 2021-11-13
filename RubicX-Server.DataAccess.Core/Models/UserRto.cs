using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubicX_Server.DataAccess.Core.Models
{
    [Table("User")]
    public class UserRto
    {
        [Key] public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string AvatarUrl { get; set; }
        public string Introduction { get; set; }
        public UserRoleRto Role { get; set; }
        [NotMapped]
        public string GetFullname 
        {
            get => LastName + " " + Firstname + " " + Patronymic;

        }
    }
}
