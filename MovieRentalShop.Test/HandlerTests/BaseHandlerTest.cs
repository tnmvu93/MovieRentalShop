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
        protected IMappingEngine Mapper;
     
        [SetUp]
        protected virtual void SetUp()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfile<MappingFromEntityProfile>();
            });

            Mapper = AutoMapper.Mapper.Engine;
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
