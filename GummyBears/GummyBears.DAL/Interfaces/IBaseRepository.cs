using GummyBears.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GummyBears.DAL.Interfaces
{
    public interface IBaseRepository<DBModel, ServiceModel>
           where DBModel : IObjWithId
           where ServiceModel : class
    {
        ServiceModel GetById(int id);

        List<ServiceModel> GetAll();

        int Create(ServiceModel model);

        void Update(ServiceModel model);

        void Delete(int id);

        DBModel FromModelToDB(ServiceModel model);

        ServiceModel FromDBToModel(DBModel dbModel);
    }
}
