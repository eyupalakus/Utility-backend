using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityCRUD.DataAccess.Abstract;
using UtilityCRUD.DataAccess.Concrete;
using UtilityCRUD.Entities;

namespace UtilityCRUD.Business.Concrete
{
    public class UtilityService : IUtilityService

    {
        private IUtilityRepository _utilityRepository;
        public UtilityService()
        {
            _utilityRepository = new UtilityRepository();
        }
        public Utility CreateUtility(Utility utility)
        {
            return _utilityRepository.CreateUtility(utility);
        }

        public void DeleteUtility(int id)
        {
           _utilityRepository.DeleteUtility(id);
        }

        public List<Utility> GetAllUtility()
        {
          return  _utilityRepository.GetAllUtility();
        }

        public Utility GetUtilityById(int id)
        {
            if (id > 0)
            {
                return _utilityRepository.GetUtilityById(id);
            }
            throw new Exception("id can't be less than 1");
        }

        public Utility UpdateUtility(Utility utility)
        {
           return _utilityRepository.UpdateUtility(utility);
        }
    }
}
