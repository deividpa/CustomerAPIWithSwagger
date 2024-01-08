using System.ComponentModel.DataAnnotations;

namespace backend.DTOs
{
    public class CreateCustomerDTO
    {
        [Required (ErrorMessage = "The First Name field is mandatory")]
        public string firstName { get; set; }
        [Required (ErrorMessage = "The Last Name field is mandatory")]
        public string lastName { get; set; }
        public string phone { get; set; }
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,6}$", ErrorMessage = "The email field is invalid")]
        public string email { get; set; }
    }
}
