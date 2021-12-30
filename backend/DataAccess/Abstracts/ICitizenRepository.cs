using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICitizenRepository
    {
        List<Citizen> GetAllCitizens();
        Citizen GetCitizenByID(int id);
        Citizen CreateCitizen(Citizen citizen);
        Citizen UpdateCitizen(Citizen citizen);
        void DeleteCitizen(int id);
    }
}
