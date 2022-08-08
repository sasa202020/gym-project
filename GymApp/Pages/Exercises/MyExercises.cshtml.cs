

namespace GymApp.Pages.Exercises
{
    public class MyExercisesModel : PageModel
    {
        private readonly ISelectedExercisesService sService;
        private readonly IAppUserService aService;

        public MyExercisesModel(ISelectedExercisesService sService, IAppUserService aService)
        {
            this.sService = sService;
            this.aService = aService;
        }
        public void OnGet()
        {
        }
    }
}
