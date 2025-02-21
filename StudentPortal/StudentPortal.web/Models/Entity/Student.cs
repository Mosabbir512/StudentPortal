using Microsoft.Identity.Client;

namespace StudentPortal.web.Models.Entity
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public String Phone { get; set; }
        public bool Subscribed { get; set; }
    }
}
