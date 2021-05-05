using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FormSample.Pages
{
    public class CalcModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int X { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Y { get; set; }

        public int Result { get; set; }

        public void OnGet()
        {
            Result = X + Y;
        }
    }
}
