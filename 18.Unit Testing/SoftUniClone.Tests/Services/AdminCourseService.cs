using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftUniClone.Data;
using SoftUniClone.Services.Admin;
using SoftUniClone.Tests.Mocks;
using System.Linq;
using System.Threading.Tasks;

namespace SoftUniClone.Tests.Services
{
    [TestClass]
    public class AdminCourseService
    {

        private SoftUniCloneContext DbContext { get; set; }

        private IMapper Mapper { get; set; }

        private AdminCoursesService Service;

        [TestInitialize]
        public void BeforeEachTest()
        {
            this.DbContext = MockDbContext.GetContext();
            
            this.Mapper = AutoMapper.Mapper.Instance;

            this.Service = new AdminCoursesService(this.DbContext, this.Mapper);
        }
        
        [TestCleanup]
        public void AfterEachTest()
        {}
        
        [TestMethod] 
        public async Task GetAllCourses_WithFewCourses_ShouldReturnAll()
        {
            this.DbContext.Courses.Add(new Models.Course() { Id = 1, Name = "My Course" });
            this.DbContext.Courses.Add(new Models.Course() { Id = 2, Name = "My Course 2" });
            this.DbContext.Courses.Add(new Models.Course() { Id = 3, Name = "My Course 3" });
            this.DbContext.SaveChanges();

            var courses = await this.Service.GetCoursesAsync();

            Assert.IsNotNull(courses);
            Assert.AreEqual(courses.Count(), 3);
        }

        [TestMethod] 
        public async Task GetAllCourses_WithNoCourses_ShouldReturnNone()
        {
            this.DbContext.SaveChanges();

            var courses = await this.Service.GetCoursesAsync();

            Assert.IsNotNull(courses);
            Assert.AreEqual(courses.Count(), 0);
        }
    }
}









