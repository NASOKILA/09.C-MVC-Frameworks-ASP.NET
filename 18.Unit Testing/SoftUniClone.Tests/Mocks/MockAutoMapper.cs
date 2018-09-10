using AutoMapper;
using SoftUniClone.Web.Mapping;

namespace SoftUniClone.Tests.Mocks
{
    public static class MockAutoMapper
    {
        public static IMapper GetMapper()
        {
            Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());

            return Mapper.Instance;
        }
    }
}
