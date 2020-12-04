using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using UnitTestingCore.Controllers;
using UnitTestingCore.Models;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]      
            public void TestIndexMethod()
            {
                //Arrange
                var controller = new HomeController();
                string viewName = "Index";
                string name = "Arpit";
                int id = 1;
                
                //Act
                var result = controller.Index() as ViewResult;
                var model = (Employee)result.Model;

                //Assert
                Assert.Equal(viewName, result.ViewName);
                Assert.Equal(name, model.Name);
                Assert.Equal(id, model.Id);
                Assert.True(model.IsExist);
                Assert.Contains(name, model.Name);
            
            }
        [Fact]
        public void EmployeePresenceTest()       
        {
            //Arrange
            var mock = new Mock<IEmployeeInterface>();
            mock.Setup(e => e.GetEmployeeById(1)).Returns("Rahul");
            HomeController controller = new HomeController(mock.Object);

            //Act
            string result = controller.GetEmployeeById(1);

            //Assert
            Assert.Equal("Rahul", result);
            Assert.NotEmpty(result);
            Assert.Single(result);
            //Assert.Null(result);
            Assert.NotNull(result);
            
            
        }


        
    }
}
