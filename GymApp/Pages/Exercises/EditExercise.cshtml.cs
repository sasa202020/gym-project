using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GymApp.Pages.Exercises
{
    public class EditExerciseModel : PageModel
    {
        private readonly IExerciseService service;

        public EditExerciseModel(IExerciseService service, ISelectedExercisesService sService, IAppUserService aService)
        {
            this.service = service;
        }

        [BindProperty]
        public Exercise Exercise { get; set; }

        public async Task OnGet(int eId)
        {
            Exercise = await service.GetExerciseByIdAsync(eId);
        }
        public async Task<IActionResult> OnPost()
        {
            await service.EditExerciseAsync(Exercise);
            return RedirectToPage("AllExercises");
        }
    }
}
