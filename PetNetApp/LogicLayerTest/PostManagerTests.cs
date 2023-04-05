﻿using DataObjects;
using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LogicLayerTest
{
    [TestClass]
    public class PostManagerTests
    {
        PostManager postManager = null;

        [TestInitialize]
        public void TestSetup()
        {
            postManager = new PostManager(new DataAccessLayerFakes.PostAccessorFake());
        }

        [TestMethod]
        public void TestRetrieveAllPosts()
        {
            int expectedResult = 4;
            int actualResult = 0;

            actualResult = postManager.RetrieveAllPosts().Count;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestRetrieveActivePosts()
        {
            int expectedResult = 3;
            int actualResult = 0;

            actualResult = postManager.RetrieveActivePosts().Count;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestAddPost()
        {
            int expectedResult = 1;
            int actualResult = 0;
            PostVM post = new PostVM();
            post.PostId = 4;

            actualResult = postManager.AddPost(post);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestEditPost()
        {
            bool expectedResult = true;
            bool actualResult = false;
            PostVM post = new PostVM();
            post.PostId = 5;

            PostVM newPost = new PostVM();
            newPost.PostContent = "Test";
            newPost.PostDate = DateTime.Today;

            actualResult = postManager.EditPost(post, newPost);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestRetrievePostByPostId()
        {
            int expectedId = 1;
            int actualId = 0;

            actualId = postManager.RetrievePostByPostId(1).PostId;
            Assert.AreEqual(expectedId, actualId);
        }
    }
}