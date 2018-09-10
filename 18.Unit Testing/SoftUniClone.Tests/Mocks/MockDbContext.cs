using Microsoft.EntityFrameworkCore;
using SoftUniClone.Data;
using System;

namespace SoftUniClone.Tests.Mocks
{
    public static class MockDbContext
    {
        public static SoftUniCloneContext GetContext()
        {
            var options = new DbContextOptionsBuilder<SoftUniCloneContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) 
                .Options;


            var DbContext = new SoftUniCloneContext(options);
            

            return DbContext;
        }        
    }
}
