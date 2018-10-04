using System.Web.Mvc;

namespace BugTrackerApplication.Models
{
    public class AppUsers
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public MultiSelectList Roles { get; set; }
        public string[] SelectedRoles { get; set; }
    }
}