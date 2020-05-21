using Biblioteca.Models;
using Biblioteca.Services.ImplementationServices;
using Biblioteca.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_LogicTest.Services
{
    [TestClass]
    public class BookServiceTest
    {
        private Mock<IRepositoryWrapper> bookRepoMock = new Mock<IRepositoryWrapper>();
        private int id = 2;

        [TestInitialize]
        public void InitializeTest()
        {
            var book = new Book
            {
                ID = 2,
                Title = "ceva",
                Price = "20",
                Status = "yes",
                Type = "ceva1",
                Author = "brb",
            };

            bookRepoMock.Setup(teacherRepo => teacherRepo.Save());
        }

        [TestMethod]
        public void GetAllBooksTest()
        {
            var bookService = new BookService(bookRepoMock.Object);

            var badBook = "sadjshd";

            Assert.AreEqual(bookService, badBook);
        }

        [TestMethod]
        public void GetDetailsByIdTest()
        {
            var bookService = new BookService(bookRepoMock.Object);

            var badID = " adas";

            Assert.AreEqual(bookService, badID);
        }

        [TestMethod]
        public void CreateTest()
        {
            var bookService = new BookService(bookRepoMock.Object);

            var badName = "testbad";

            Assert.AreEqual(bookService, badName);
        }

        [TestMethod]
        public void ExitsTest()
        {
            var bookService = new BookService(bookRepoMock.Object);

            var flag = true;

            Assert.AreEqual(bookService, flag);
        }

    }
}
