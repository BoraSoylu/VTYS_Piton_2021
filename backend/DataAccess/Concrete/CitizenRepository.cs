using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CitizenRepository : ICitizenRepository
    {
        public Citizen CreateCitizen(Citizen citizen)
        {
            FISContext context = new FISContext();
            context.Citizens.Add(citizen);
            context.SaveChanges();
            context.Dispose();
            return citizen;
        }

        public void DeleteCitizen(int id)
        {
            FISContext context = new FISContext();
            Citizen citizen = this.GetCitizenByID(id);
            context.Citizens.Remove(citizen);
            context.SaveChanges();
            context.Dispose();
        }

        public List<Citizen> GetAllCitizens()
        {
            FISContext context = new FISContext();
            List<Citizen> citizens = context.Citizens.ToList();
            context.Dispose();
            return citizens;
        }

        public Citizen GetCitizenByID(int id)
        {
            FISContext context = new FISContext();
            Citizen citizen = context.Citizens.Find(id);
            context.Dispose();
            return citizen;
        }

        public Citizen UpdateCitizen(Citizen citizen)
        {
            FISContext context = new FISContext();
            context.Citizens.Update(citizen);
            context.Dispose();
            return citizen;
        }
    }
}
