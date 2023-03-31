using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityCRUD.DataAccess.Abstract;
using UtilityCRUD.Entities;

namespace UtilityCRUD.DataAccess.Concrete
{
    public class UtilityRepository : IUtilityRepository
    {
        public Utility CreateUtility(Utility utility)
        {
            using (var utilitydbcontext = new UtilityDbContext())
            {
                utilitydbcontext.Utilities.Add(utility);
                utilitydbcontext.SaveChanges();
                return utility;
            }
        }

        public void DeleteUtility(int id)
        {
            using (var utilitydbcontext = new UtilityDbContext())
            {
                var deleted=GetUtilityById(id);
                utilitydbcontext.Remove(deleted);
                utilitydbcontext.SaveChanges();
            }
        }

        public List<Utility> GetAllUtility()
        {
            using (var utilitydbcontext=new UtilityDbContext())
            {
                return utilitydbcontext.Utilities.ToList();
            }
        }

        public Utility GetUtilityById(int id)
        {
            using (var utilitydbcontext = new UtilityDbContext())
            {
                return utilitydbcontext.Utilities.Find(id);
            }
        }

        public Utility UpdateUtility(Utility utility)
        {
            using (var utilitydbcontext = new UtilityDbContext())
            {
                utilitydbcontext.Utilities.Update(utility);
                utilitydbcontext.SaveChanges();
                return utility;
            }
        }
    }
}
