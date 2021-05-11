using HMS.Data;
using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Services
{
    public class AccomodationTypesAPIService
    {
        public IEnumerable<AccomodationType> GetAllATA()
        {
            var context = new HMSContext();

            return context.AccomodationTypes;
        }

        public AccomodationType GetATAByID(int ID)
        {
            var context = new HMSContext();

            return context.AccomodationTypes.Find(ID);
        }
    }

}
