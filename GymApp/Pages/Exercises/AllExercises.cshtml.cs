
namespace GymApp.Pages.Exercises
{
    public class AllExercisesModel : PageModel
    {
        private readonly IExerciseService service;
        private readonly ISelectedExercisesService sService;
        private readonly IAppUserService aService;

        public AllExercisesModel(IExerciseService service, ISelectedExercisesService sService, IAppUserService aService)
        {
            this.service = service;
            this.sService = sService;
            this.aService = aService;
        }

        public IEnumerable<Exercise> AllExercises { get; set; }

        public async Task OnGet()
        {
            AllExercises = await service.GetAllExercisesAsync();
        }
        public async Task<IActionResult> OnPost(IEnumerable<Exercise> exercises)
        {
            AppUser loggedInUser = await aService.GetLoggedInUser(User.Identity.Name);
            await sService.AddSelectExercisesAsync(exercises, loggedInUser.Id);
            return RedirectToPage("MyExercises");
        }
    }
}
