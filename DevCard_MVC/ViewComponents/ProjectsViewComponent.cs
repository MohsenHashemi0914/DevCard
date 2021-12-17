using DevCard_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = ProjectStore.GetProjects();
            return View("_Projects", projects);
        }
    }
}
