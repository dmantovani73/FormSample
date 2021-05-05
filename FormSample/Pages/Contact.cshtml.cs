using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using FormSample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormSample.Pages
{
    public class ContactModel : PageModel
    {
        readonly FormContactContext _db;

        public ContactModel(FormContactContext db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> Languages = new[]
        {
            new SelectListItem("Italiano", "it"),
            new SelectListItem("English", "en"),
        };

        [Required]
        [Display(Name = "Nome e cognome")]
        [BindProperty]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [BindProperty]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data di nascita")]
        [BindProperty]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Lingua")]
        [BindProperty]
        public string Language { get; set; }

        public void OnGet()
        { }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                _db.FormContacts.Add(new FormContact
                {
                    Name = Name,
                    Email = Email,
                    DateOfBirth = DateOfBirth,
                    Language = Language,
                });

                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
