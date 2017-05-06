using GummyBears.DTO.Interfaces;

namespace GummyBears.DAL.Interfaces
{
    public interface IBaseRepository<DBModel, ServiceModel>
           where DBModel : class, IObjWithId
           where ServiceModel : class
    {
        ServiceModel GetById(int id);

        ServiceModel[] GetAll();

        int Create(ServiceModel model);

        void Update(ServiceModel model);

        void Delete(int id);

        DBModel FromModelToDB(ServiceModel model);

        ServiceModel FromDBToModel(DBModel dbModel);
    }
}
