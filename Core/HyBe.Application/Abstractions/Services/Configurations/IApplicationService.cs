using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Application.Abstractions.Services.Configurations
{
    public interface IApplicationService
    {
        List<Menu> GetAuthorizeDefinitionEndpoints(Type type);
    }
}