using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.MappingProfile
{
    public static class MappingConfiguration
    {
        public static MapperConfiguration RegisterMap()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new BrandProfile());
            });
        }
    }
}
