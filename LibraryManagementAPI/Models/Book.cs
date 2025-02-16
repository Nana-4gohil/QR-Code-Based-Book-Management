using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }


        [Required,MaxLength(255)]

        public string Title { get; set; }

        [Required,MaxLength(255)]

        public string Author { get; set; }

        [MaxLength(13)]

        public string ISBN { get; set; }


        [Required]

        public string QRCode { get; set; }

        [Required]

        public bool IsAvailable { get; set; } = true;



    }
}
