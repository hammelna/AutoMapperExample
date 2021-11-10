using AutoMapper;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapperTests
{
    [TestClass]
    public class MapperValidationTests
    {
        [TestMethod]
        public void ValidateMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MapperProfile>());

            configuration.AssertConfigurationIsValid();
        }
    }
}
