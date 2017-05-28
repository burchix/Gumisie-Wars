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

            #region Game

            CreateMap<GameDB, Game>()
                .ForMember(m => m.PlayerMoves, 
                           opts => opts.ResolveUsing((s, d, m, c) => { c.Items["Player"] = true; return new PlayerActionsResolver().Resolve(s, d, m, c); }))
                .ForMember(m => m.OpponentMoves, 
                           opts => opts.ResolveUsing((s, d, m, c) => { c.Items["Player"] = false; return new PlayerActionsResolver().Resolve(s, d, m, c); }));

            CreateMap<Game, GameDB>()
                .ForMember(db => db.PlayerMoves, 
                           opts => opts.ResolveUsing((s, d, m, c) => { c.Items["Player"] = true; return new PlayerActionsResolver().Resolve(s, d, m, c); }))
                .ForMember(db => db.OpponentMoves, 
                           opts => opts.ResolveUsing((s, d, m, c) => { c.Items["Player"] = false; return new PlayerActionsResolver().Resolve(s, d, m, c); }));

            #endregion

            #region Map

            CreateMap<MapDB, Map>()
                .ForMember(m => m.Fields, opts => opts.ResolveUsing((s, d, m, c) => new MapResolver().Resolve(s, d, m, c)));

            CreateMap<Map, MapDB>()
                .ForMember(db => db.DefenceMultiplier,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.DefenceMultiplier.ToString("N5")))))
                .ForMember(db => db.GummiesMultiplier,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.GummiesMultiplier.ToString()))))
                .ForMember(db => db.GoldMultiplier,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.GoldMultiplier.ToString("N5")))))
                .ForMember(db => db.JuiceMultiplier,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.JuiceMultiplier.ToString("N5")))))
                .ForMember(db => db.GummiesNumber,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => x.GummiesNumber.ToString("N5")))))
                .ForMember(db => db.GummiesType,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => (int)x.GummiesType))))
                .ForMember(db => db.Owner,
                           opts => opts.ResolveUsing((s, d, m) => string.Join(";", s.Fields.Select(x => (int)x.Owner))));

            #endregion
        }
    }
}
