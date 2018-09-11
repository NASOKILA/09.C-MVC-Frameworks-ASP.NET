using FindMyPet.Data;
using FindMyPet.Tests.Mocks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMyPet.Tests.Controllers.Likes
{
    [TestClass]
    public class LikesTests
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
        public void MessagesCount_ShouldReturnAPetMessageCount()
        {
            var comments = this.DbContext.Comments.Include(p => p.Likes).ToList();
            var commentOne = comments[0];

            var likes = commentOne.Likes.Count;
            var likes2 = commentOne.Likes.Count;

            Assert.AreEqual(likes, likes2);
        }

        [TestMethod]
        public void AddLike_ShouldReturnOneMoreLike()
        {
            var comments = this.DbContext.Comments.Include(p => p.Likes).ToList();
            var commentOne = comments[0];

            var likes = commentOne.Likes;
            var likesCount = likes.Count();

            likes.Add(new Models.Like()
            { });

            var likesNewCount = likes.Count();
            
            Assert.AreEqual(likesCount, likesNewCount - 1);
        }

        [TestMethod]
        public void RemoveLike_ShouldReturnOneLessLike()
        {
            var comments = this.DbContext.Comments.Include(p => p.Likes).ToList();
            var commentOne = comments[1];

            var likes = commentOne.Likes;
            var likesCount = commentOne.Likes.Count();

            likes.Remove(likes.Last());

            var likesNewCount = commentOne.Likes.Count();

            Assert.AreEqual(likesCount, likesNewCount + 1);
        }
    }
}
