using System.Collections.Generic;
using System.Linq;
using DevCard_MVC.Models;

namespace DevCard_MVC.Data
{
    public class ProjectStore
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(1, "مدیریت خوابگاه", "مدیریت سیستم خوابگاه","project-1.jpg", "Ariyana"),
                new Project(2, "اسنپ فود", "مدیریت سیستم ارسال غذا به کل کشور", "project-2.jpg", "People"),
                new Project(3, "نوبت دهی آنلاین پزشکی", "مدیریت سیستم نوبت دهی", "project-3.jpg", "Doctors"),
                new Project(4, "ثبتنام املاک", "سیستم ثبتنام آنلاین املاک", "project-4.jpg", "People")
            };
        }

        public static Project GetProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(p => p.Id == id);
        }
    }
}
