using AutoMapper;
using BLL.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public abstract class BaseAutoMapper
    {
        protected BaseAutoMapper()
        {
            Mapper.Initialize(MappingConfiguration.Configuration);
        }
    }
}
