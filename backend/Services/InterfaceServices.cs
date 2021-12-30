using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class InterfaceServices
    {
        public interface ICitizen
        {
            List<Citizen> GetAllCitizens();
            Citizen GetCitizenByID(int id);
            Citizen CreateCitizen(Citizen citizen);
            Citizen UpdateCitizen(Citizen citizen);
            void DeleteCitizen(int id);
        }
    }
}
