using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MISProject.Pages
{
    public class playerStatModel : PageModel
    {

        public string JsonData { get; private set; }
        public void OnGet(string JData)
        {
            JsonData = JData;
        }
    }
}
