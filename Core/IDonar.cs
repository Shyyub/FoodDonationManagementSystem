using FoodDonationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Core
{
    public interface IDonar
    {
        IEnumerable<SchoolModel> GetAll();
        void AddDonar(SchoolModel schoolModel);
    }
}
