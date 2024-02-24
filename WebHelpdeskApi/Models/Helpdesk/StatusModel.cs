namespace WebHelpdeskApi.Models.Helpdesk
{
    public class StatusModel
    {
        public enum Status
        {
            Open, 
            InProgress, 
            Closed, 
            InDevelopmentBug, 
            InDevelopmentNewFeature 
        }
    }
}
