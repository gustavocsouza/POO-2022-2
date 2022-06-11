namespace CrudClientChargesAp2.Models.Domains
{
    public class Client
    {
        public Client(){}
        public Client(int id, string name, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        

    }
}