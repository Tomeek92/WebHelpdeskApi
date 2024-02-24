using System.ComponentModel.DataAnnotations;

namespace WebHelpdeskApi.Models.Helpdesk
{
    public class DepartmentModel
    {
        [Key]
        public Guid Id { get; set; }
        public string DepartmentName { get; set; } 
        public string UserDepartment {  get; set; }
        public DateTime CreateTime { get; set; }    
    }
}
