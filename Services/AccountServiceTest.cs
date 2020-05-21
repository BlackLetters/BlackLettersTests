using Biblioteca.Models;
using Biblioteca.Services.ImplementationServices;
using Biblioteca.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_LogicTest
{
    [TestClass]
    public class AccountServiceTest
    {
        private Mock<AccountService> accountServiceMock = new Mock<AccountService>();
        private Mock<IRepositoryWrapper> accountRepoMock = new Mock<IRepositoryWrapper>();
        private int id = 2;

        [TestInitialize]
        public void InitializeTest()
        {
            var account = new Account
            {
                ID = 2,
                Name = "ceva",
                Email = "ceva@ceva.com",
                Password = "ceva2", 
                Username = "ceva1",
                UserRole = "brb",
            };

            accountRepoMock.Setup(teacherRepo => teacherRepo.Save());
        }

        [TestMethod]
        public void GetAllAccountsTest()
        {
            var accountService = new AccountService(accountRepoMock.Object);

            var badAccount = "sadjshd";

            Assert.AreEqual(accountService, badAccount);
        }

        [TestMethod]
        public void GetDetailsByIdTest()
        {
            var accountService = new AccountService(accountRepoMock.Object);

            var badID = " adas";

            Assert.AreEqual(accountService, badID);
        }

        [TestMethod]
        public void CreateTest()
        {
            var accountService = new AccountService(accountRepoMock.Object);

            var badName = "testbad";

            Assert.AreEqual(accountService, badName);
        }

        [TestMethod]
        public void ExitsTest()
        {
            var accountService = new AccountService(accountRepoMock.Object);

            var flag = true;

            Assert.AreEqual(accountService, flag);
        }

    }
}
