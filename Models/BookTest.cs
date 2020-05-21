using Biblioteca.Context;
using Biblioteca.Controllers;
using Biblioteca.Models;
using Biblioteca.Services.ImplementationServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_LogicTest
{
    [TestClass]
    class BookTest
    {

        [TestMethod]
        public void CreateBookTest()
        {
            //Arrange- Define testing content

            int ID = 2;
            string Title = "testBook2";
            float Price = 20;
            string Status = "avalaible";
            string Type = "testType";
            string Author = "testAuthor";

            //Act
            var book = new Book()
            {
                Title = "testbook",
                Price = "20",
                Status = "avalaible",
                Type = "testType",
                Author = "testAuthor",
            };

            //Assert
            Assert.AreEqual(Title, book.Title);
            Assert.AreEqual(Price, book.Price);
            Assert.AreEqual(Status, book.Status);
            Assert.AreEqual(Type, book.Type);
            Assert.AreEqual(Author, book.Author);
        }

        [TestMethod]
        public void EditBookTest()
        {
            //Arrange- Define testing content
         
            int ID = 2;
            string Title = "testBook2";
            float Price = 20;
            string Status = "avalaible";
            string Type = "testType";
            string Author = "testAuthor";

            //Act
            var book = new Book() {
                Title = "testbook",
                Price = "20",
                Status = "avalaible",
                Type = "testType",
                Author = "testAuthor",
                   };

            //Assert
            Assert.AreEqual(Title, book.Title);
            Assert.AreEqual(Price, book.Price);
            Assert.AreEqual(Status, book.Status);
            Assert.AreEqual(Type, book.Type);
            Assert.AreEqual(Author, book.Author);
            }

        [TestMethod]
        public void ExistsBookTest()
        {
            //Arrange- Define testing content

            int ID = 2;
            string Title = "testBook2";
            float Price = 20;
            string Status = "avalaible";
            string Type = "testType";
            string Author = "testAuthor";

            //Act
            var book = new Book()
            {
                Title = "testbook",
                Price = "20",
                Status = "avalaible",
                Type = "testType",
                Author = "testAuthor",
            };

            //Assert
            Assert.AreEqual(Title, book.Title);
            Assert.AreEqual(Price, book.Price);
            Assert.AreEqual(Status, book.Status);
            Assert.AreEqual(Type, book.Type);
            Assert.AreEqual(Author, book.Author);
        }

        [TestMethod]
        public void DeleteBookTest()
        {
            //Arrange- Define testing content

            int ID = 2;
            string Title = "testBook2";
            float Price = 20;
            string Status = "avalaible";
            string Type = "testType";
            string Author = "testAuthor";

            //Act
            var book = new Book()
            {
                Title = "testbook",
                Price = "20",
                Status = "avalaible",
                Type = "testType",
                Author = "testAuthor",
            };

            //Assert
            Assert.AreEqual(Title, book.Title);
            Assert.AreEqual(Price, book.Price);
            Assert.AreEqual(Status, book.Status);
            Assert.AreEqual(Type, book.Type);
            Assert.AreEqual(Author, book.Author);
        }
    }
}