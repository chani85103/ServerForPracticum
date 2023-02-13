namespace Clients.WebApi.Models
{
    public class ChildModel
    {
        #region data members
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        #endregion
    }
}
