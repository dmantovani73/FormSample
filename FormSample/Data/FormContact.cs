using System;
using System.ComponentModel.DataAnnotations;

namespace FormSample.Data
{
    public class FormContact
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Language { get; set; }
    }
}
