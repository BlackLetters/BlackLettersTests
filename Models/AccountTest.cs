using Biblioteca.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Biblioteca_LogicTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void EditAccountTest()
        {
            //Arrange- Define testing content

            int ID = 2;
            string Title = "testBook2";
            float Price = 20;
            string Status = "avalaible";
            string Type = "testType";
            string Author = "testAuthor";

            //Act
            //var book = new Book(){parametrii};
            var account = new Account()
            {
                Name = "testaccount",
                Password = "ceva",
                Username = "avalaible",
                UserRole = "testType",
            };
            //(Title, Price, Status, Type, Author);

            //Assert
            Assert.AreEqual(Title, account.Name);
            Assert.AreEqual(Price, account.Password);
            Assert.AreEqual(Status, account.Username);
            Assert.AreEqual(Type, account.UserRole);
        }
    }
}
