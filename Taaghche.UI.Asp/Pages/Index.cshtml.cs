using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taaghche.UI.Asp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Services.BookMetadataService _bookMetadataService;

        public IndexModel(ILogger<IndexModel> logger, Services.BookMetadataService bookMetadataService)
        {
            _logger = logger;
            _bookMetadataService = bookMetadataService;
        }
        public async Task<IActionResult> OnPostBookId(string id)
        {
            if (int.TryParse(id, out var bookId))
            {
                if (id.Length != 5)
                    ViewData["Error"] = "لطفا یک عدد 5 رقمی وارد کنید";
                else
                {
                    ViewData["Book"] = await _bookMetadataService.Get(new Dictionary<string, object>() { ["id"] = bookId });
                    if (ViewData["Book"] == null) ViewData["Error"] = "کتاب درخواستی پیدا نشد";
                }
            }
            else
                ViewData["Error"] = "فقط عدد مورد قبول است";

            return Page();
        }
        public void OnGet()
        {

        }
    }
}
