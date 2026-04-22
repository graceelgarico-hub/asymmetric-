using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SaddleVolumeCalc.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double LengthA { get; set; }
        [BindProperty]
        public double WidthB { get; set; }
        [BindProperty]
        public double HeightH { get; set; }
        public double? Result { get; set; }

        public void OnGet() { }

        public void OnPost()
        {
            // Formula for Asymmetric Hyperbolic Paraboloid Volume: V = 1/4 * a * b * h
            Result = 0.25 * LengthA * WidthB * HeightH;
        }
    }
}