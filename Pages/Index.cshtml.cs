using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FormSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<SelectListItem> Languages => new[]
        {
            new SelectListItem { Text = "Italiano", Value = "it" },
            new SelectListItem { Text = "Inglese", Value = "en" },
        };

        [BindProperty]
        public InputModel Input { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        { }

        public void OnPost()
        {
            if (!ModelState.IsValid) return;

            // Salva i dati.
         }

        public class InputModel
        {
            [Required]
            [Display(Name = "Nome")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Cognome")]
            public string LastName { get; set; }

            [Display(Name = "Data di nascita")]
            [DataType(DataType.Date)]
            public DateTime? DateOfBirth { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Display(Name = "Lingua")]
            public string Language { get; set; }
        }
    }
}
