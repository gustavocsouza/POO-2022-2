using CrudClientChargesAp2.Models.Domains;
using Microsoft.EntityFrameworkCore;
namespace CrudClientChargesAp2.Models.Repositories
{
    public class ClientRepository: IClientRepository
    {
        private DataContext context;
        public ClientRepository(DataContext context){
            this.context = context;
        }
        public void Create(Client entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Clients.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Client> GetAll()
        {
           return context.Clients.ToList();
        }

        public Client GetById(int id)
        {
            return context.Clients.SingleOrDefault(i=>i.Id == id);
        }

        public void Update(Client entity)
        {
            context.Clients.Update(entity);
            context.SaveChanges();
        }
    }
}