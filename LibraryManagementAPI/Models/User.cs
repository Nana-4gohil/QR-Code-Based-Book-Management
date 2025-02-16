
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(100)]

        public string FullName { get; set; }

        [Required,MaxLength(100), EmailAddress]

        public string Email { get; set; }

        [Required]

        public string PasswordHash { get; set; }

        [Required]

        public string Role { get; set; }


        public 


    }
}
