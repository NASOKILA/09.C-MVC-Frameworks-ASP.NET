using FindMyPet.Data;
using FindMyPet.Models;
using FindMyPet.Tests.Mocks;
using FindMyPet.Web.Areas.Admin.Controllers;
using FindMyPet.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FindMyPet.Tests.Controllers.PetsController
{
    [TestClass]
    public class PetsTests
    {
        private FindMyPetDbContext DbContext { get; set; }
        
        [TestInitialize]
        public void BeforeEachTest()
        {
            this.DbContext = MockDbContext.GetContext();
        }

        [TestCleanup]
        public void AfterEachTest()
        { }

        
        [TestMethod] 
        public void GetAllPetsCount_ShouldReturnAllPetsCount()
        {
            var pets = this.DbContext.Pets.ToList();
            var petsCount = pets.Count;
            var petsCount2 = pets.Count;

            Assert.AreEqual(petsCount, petsCount2);
        }


        [TestMethod]
        public void AddingPets_ShouldAddOnePet()
        {
            var pets = this.DbContext.Pets.ToList();
            var petsOldCount = pets.Count;


            pets.Add(new Pet()
            {
                Type = "Dog",
                Name = "Jaky2",
                Age = 15,
                LocationLost = "Varna",
                TimeLost = DateTime.Now,
                Comments = new List<Comment>(),
                Status = "Lost",
                ImageUrl = "https://static.boredpanda.com/blog/wp-content/uploads/2017/09/funny-dog-thoughts-tweets-1.jpg"

            });

            var petsNewCount = pets.Count;

            Assert.AreEqual(petsOldCount, petsNewCount-1);
        }


        [TestMethod]
        public void RemovePet_ShouldremovePet()
        {
            var pets = this.DbContext.Pets.ToList();
            var petsOldCount = pets.Count;
            
            pets.Remove(pets.Last());
            var petsNewCount = pets.ToList().Count;
             q
            Assert.AreEqual(petsOldCount, petsNewCount + 1);
        }
    }
}
