using AutoMapper;
using System.Collections.Generic;

namespace IBO.Common.Mapper
{
    public static class EntityMapper<T1, T2>
    {
        public static T2 MapEntity(T1 entity)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<T2>(entity);
        }
        public static List<T2> MapEntityCollection(List<T1> entities)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<T2>>(entities);
        }

        public static T2 MapEntity<T3, T4>(T1 entity)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
                cfg.CreateMap<T3, T4>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<T2>(entity);
        }

        public static List<T2> MapEntityCollection<T3, T4>(List<T1> entities)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T1, T2>();
                cfg.CreateMap<T3, T4>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<T2>>(entities);
        }
    }
}
