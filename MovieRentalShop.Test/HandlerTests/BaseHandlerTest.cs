using AutoMapper;
using Effort;
using MovieRentalShop.Handler.Mapping;
using NUnit.Framework;
using System.Data.Common;

namespace MovieRentalShop.Test.HandlerTests
{
    [TestFixture]
    public class BaseHandlerTest 
    {
        protected IMapper Mapper;
     
        [SetUp]
        protected virtual void SetUp()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfile<MappingFromEntityProfile>();
                x.AddProfile<MappingToEntityProfile>();
            });

            Mapper = AutoMapper.Mapper.Instance;
        }

        [TearDown]
        protected virtual void TearDown()
        {
        }

        protected DbConnection GetTransientConnection()
        {
            return DbConnectionFactory.CreateTransient(Initialize.DataLoader);
        }
    }
}
