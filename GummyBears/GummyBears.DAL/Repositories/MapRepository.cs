using AutoMapper;
using GummyBears.Common.Models;
using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Models;
using System.Data.Entity;

namespace GummyBears.DAL.Repositories
{
    public class MapRepository : BaseRepository<MapDB, Map>, IMapRepository
    {
        public MapRepository(DbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
