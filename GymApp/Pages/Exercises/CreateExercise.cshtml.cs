using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GymApp.Pages.Exercises
{
    public class CreateExerciseModel : PageModel
    {
        private readonly IExerciseService service;

        public CreateExerciseModel(IExerciseService service, ISelectedExercisesService sService, IAppUserService aService)
        {
            this.service = service;
        }

        public Exercise Exercise { get; set; }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            await service.CreateExerciseAsync(Exercise);
            return RedirectToPage("AllExercises");
        }
    }
}
