using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityCRUD.Entities;

namespace UtilityCRUD.Business
{
    public interface IUtilityService
    {
        List<Utility> GetAllUtility();
        Utility GetUtilityById(int id);
        Utility CreateUtility(Utility utility);
        Utility UpdateUtility(Utility utility);
        void DeleteUtility(int id);
    }
}
