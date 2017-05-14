using System;
using AutoMapper;
using GummyBears.Common.Models;
using GummyBears.DTO.Models;
using System.Linq;
using GummyBears.Common.Enums;

namespace GummyBears.DAL.Mapper.Resolvers
{
    class MapResolver : IValueResolver<MapDB, Map, Field[]>
    {
        public Field[] Resolve(MapDB source, Map destination, Field[] destMember, ResolutionContext context)
        {
            var defenceMultiplier = source.DefenceMultiplier.Split(';').Select(x => decimal.Parse(x)).ToArray();
            var gummiesMultiplier = source.GummiesMultiplier.Split(';').Select(x => decimal.Parse(x)).ToArray();
            var goldMultiplier = source.GoldMultiplier.Split(';').Select(x => decimal.Parse(x)).ToArray();
            var juiceMultiplier = source.JuiceMultiplier.Split(';').Select(x => decimal.Parse(x)).ToArray();
            var gummiesType = source.GummiesType.Split(';').Select(x => (GummyType)int.Parse(x)).ToArray();
            var gummiesNumber = source.GummiesNumber.Split(';').Select(x => int.Parse(x)).ToArray();
            var owner = source.Owner.Split(';').Select(x => (FieldOwner)int.Parse(x)).ToArray();

            var result = new Field[source.Width * source.Height];
            int k = 0;
            for (int i = 0; i < source.Width; i++)
                for (int j = 0; j < source.Height; j++)
                {
                    result[k] = new Field()
                    {
                        DefenceMultiplier = defenceMultiplier[k],
                        GoldMultiplier = goldMultiplier[k],
                        GummiesMultiplier = gummiesMultiplier[k],
                        GummiesNumber = gummiesNumber[k],
                        GummiesType = gummiesType[k],
                        JuiceMultiplier = juiceMultiplier[k],
                        Owner = owner[k]
                    };
                    k++;
                }

            return result;
        }
    }
}
