using AutoMapper;
using GummyBears.Common.Models;
using GummyBears.DAL.Mapper.Resolvers;
using GummyBears.DTO.Models;
using System.Linq;

namespace GummyBears.DAL.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Game

            CreateMap<GameDB, Game>();
            CreateMap<Game, GameDB>();

            #endregion

            #region Stats

            CreateMap<StatsDB, Stats>();
            CreateMap<Stats, StatsDB>();

            #endregion

            #region Session

            CreateMap<SessionDB, Session>();
            CreateMap<Session, SessionDB>();

            #endregion

            #region User

            CreateMap<UserDB, User>();
            CreateMap<User, UserDB>();

            #endregion

            #region Map

            CreateMap<MapDB, Map>()
                .ForMember(m => m.Fields, opts => opts.ResolveUsing<MapResolver>());

            CreateMap<Map, MapDB>()
                .ForMember(db => db.DefenceMultiplier,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.DefenceMultiplier.ToString("N2")))))
                .ForMember(db => db.GummiesMultiplier,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.GummiesMultiplier.ToString("N2")))))
                .ForMember(db => db.GoldMultiplier,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.GoldMultiplier.ToString("N2")))))
                .ForMember(db => db.JuiceMultiplier,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.JuiceMultiplier.ToString("N2")))))
                .ForMember(db => db.GummiesNumber,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.GummiesNumber))))
                .ForMember(db => db.GummiesType,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => (int)x.GummiesType))))
                .ForMember(db => db.Owner,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => (int)x.Owner))));

            #endregion
        }
    }
}
