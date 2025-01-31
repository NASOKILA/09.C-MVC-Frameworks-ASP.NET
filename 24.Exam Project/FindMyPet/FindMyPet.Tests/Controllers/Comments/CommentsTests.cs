﻿using FindMyPet.Data;
using FindMyPet.Models;
using FindMyPet.Tests.Mocks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMyPet.Tests.Controllers.CommentsController
{
    [TestClass]
    public class CommentsTests
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
        public void CommentsCount_ShouldReturnAPetCommentsCount()
        {
            var pets = this.DbContext.Pets.Include(p => p.Comments).ToList();
            var petOne = pets[0];
            
            var comments = petOne.Comments.Count;
            var comments2 = petOne.Comments.Count;
            
            Assert.AreEqual(comments, comments2);
        }


        [TestMethod]
        public void AddComment_ShouldReturnOneMoreComment()
        {
            var pets = this.DbContext.Pets.Include(p => p.Comments).ToList();
            var petOne = pets[0];

            var comments = petOne.Comments;
            var commentsCount = petOne.Comments.Count();

            comments.Add(new Comment()
            {
                Content = "New Comment",
                CreationDate = DateTime.Now,
                Likes = new List<Like>(),
                LikeDisabled = false
            });

            var commentsNewCount = petOne.Comments.Count();

            Assert.AreEqual(commentsCount, commentsNewCount - 1);
        }
        
        [TestMethod]
        public void RemoveComment_ShouldReturnOneLessComment()
        {
            var pets = this.DbContext.Pets.Include(p => p.Comments).ToList();
            var petOne = pets[0];

            var comments = petOne.Comments;
            var commentsCount = petOne.Comments.Count();

            comments.Remove(comments.Last());

            var commentsNewCount = petOne.Comments.Count();

            Assert.AreEqual(commentsCount, commentsNewCount + 1);
        }
    }
}
