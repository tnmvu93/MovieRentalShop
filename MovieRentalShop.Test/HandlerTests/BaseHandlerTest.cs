using AutoMapper;
using AutoMapper.Mappers;
using Effort;
using NUnit.Framework;
using System.Data.Common;

namespace MovieRentalShop.Test.HandlerTests
{
    [TestFixture]
    public class BaseHandlerTest 
    {
        protected IMapper mapper;
     
        [SetUp]
        protected virtual void SetUp()
        {
            
            
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
