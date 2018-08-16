using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapping
{

        internal class MappingConfiguration
        {
            public static void Configuration(IMapperConfigurationExpression config)
            {
                config.AddProfile<MappingProfile>();
            }
        }
    }

