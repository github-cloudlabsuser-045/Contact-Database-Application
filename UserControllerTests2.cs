using CRUD_application_2.Controllers;
using CRUD_application_2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CRUD_application_2.Tests.Controllers
{
    [TestClass]
    public class UserControllerTests
    {
        [TestMethod]
        public void Index_ReturnsViewWithUserList()
        {
            // Arrange
            var controller = new UserController();
            var userList = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
            };
            UserController.userlist = userList;

            // Act
            var result = controller.Index() as ViewResult;
            var model = result.Model as List<User>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(null);
            Assert.AreEqual(userList.Count, model.Count);
            Assert.AreEqual(userList[0].Id, model[0].Id);
            Assert.AreEqual(userList[0].Name, model[0].Name);
            Assert.AreEqual(userList[0].Email, model[0].Email);
            Assert.AreEqual(userList[1].Id, model[1].Id);
            Assert.AreEqual(userList[1].Name, model[1].Name);
            Assert.AreEqual(userList[1].Email, model[1].Email);
        }
    }
}
