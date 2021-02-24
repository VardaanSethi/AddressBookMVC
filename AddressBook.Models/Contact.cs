using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(3, ErrorMessage = "Name should contain atleast 3 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression(@"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$",
            ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
        public long Mobile { get; set; }
        public long Landline { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
    }
}
