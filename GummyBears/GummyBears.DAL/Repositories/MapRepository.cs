using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using GummyBears.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GummyBears.DAL.Repositories
{
    public class MapRepository : BaseRepository<MapDB, Map>, IMapRepository
    {
        public MapRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public override Map FromDBToModel(MapDB dbModel)
        {
            throw new NotImplementedException();
        }

        public override MapDB FromModelToDB(Map model)
        {
            throw new NotImplementedException();
        }
    }
}
