namespace CrudClientChargesAp2.Models.Domains
{
    public class Charge
    {
        public int Id { get; set; }
        public string IssueDate { get; set; }
        public string DueDate { get; set; }
        public Client Client { get; set; }
    }
}