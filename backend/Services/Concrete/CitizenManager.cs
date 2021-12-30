using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class CitizenManager : Services.InterfaceServices.ICitizen
    {
        private ICitizenRepository repo;
        public CitizenManager()
        {
            repo = new CitizenRepository();
        }
        public Citizen CreateCitizen(Citizen citizen)
        {
            this.repo.CreateCitizen(citizen);
            return citizen;
        }

        public void DeleteCitizen(int id)
        {
            this.repo.DeleteCitizen(id);
        }

        public List<Citizen> GetAllCitizens()
        {
            return this.repo.GetAllCitizens();
        }

        public Citizen GetCitizenByID(int id)
        {
            return this.repo.GetCitizenByID(id);
        }

        public Citizen UpdateCitizen(Citizen citizen)
        {
            return this.repo.UpdateCitizen(citizen);
        }
    }
}
