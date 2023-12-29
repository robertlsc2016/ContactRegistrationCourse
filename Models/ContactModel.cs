//MODEL REPRESENTA A TABELA DO BANCO DE DADOS
using System.ComponentModel.DataAnnotations;

namespace ContactRegistrationCourse.Models
{
    public class ContactModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "name field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "email field is required")]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number field is required")]
        [Phone(ErrorMessage = "invalid phone number")]
        public string Phone { get; set; }
    }
}
