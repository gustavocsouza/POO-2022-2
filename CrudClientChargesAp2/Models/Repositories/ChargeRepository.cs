using CrudClientChargesAp2.Models.Domains;
using Microsoft.EntityFrameworkCore;
namespace CrudClientChargesAp2.Models.Repositories
{
    public class ChargeRepository : IChargeRepository
    {
        DataContext context;
        public ChargeRepository(DataContext context) {
            this.context = context;
        }
        public void Create(Charge charge)
        {
            
            if(charge.Client.Id>0) charge.Client = context.Clients.SingleOrDefault(x=>x.Id == charge.Client.Id);
            context.Add(charge);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Charges.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Charge> GetAll()
        {
            return context.Charges.Include(c=>c.Client).ToList();
        }

        public Charge GetById(int id)
        {
            return context.Charges.Include(c=>c.Client).SingleOrDefault(i=>i.Id == id);
        }

        public void Update(Charge charge)
        {
            context.Charges.Update(charge);
            context.SaveChanges();
        }
    }
}