namespace WebHelpdeskApi.Models.Helpdesk
{
    public class UserHelpdeskModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DepartmentModel DepartmentName { get; set; } = default!;
        public DepartmentModel DepartmentUser { get; set; } = default!;

    }
}
