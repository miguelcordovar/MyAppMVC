using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAppMVC.Controllers;
using Moq;
using MyAppMVC.Models;
using MyAppMVC.Repositories;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyAppMVC.Tests.Controllers
{
    [TestClass]
    public class EmployeeInfoControllerTest
    {
        [TestMethod]
        public void Index()
        {
            var mockRepository = new Mock<IRepository<EmployeeInfo, int>>();

            var controller = new EmployeeInfoController(mockRepository.Object);
           
            List<EmployeeInfo> employeeList = new List<EmployeeInfo>()
            {
                new EmployeeInfo() { EmpNo=1, EmpName="Miguel Córdova", DeptName="Informatica", Designation="Group Leader", Salary=5000 },
                new EmployeeInfo() { EmpNo=2, EmpName="Julio Córdova", DeptName="Informatica", Designation="Project Manager", Salary=4000 },
                new EmployeeInfo() { EmpNo=3, EmpName="Gianella Córdova", DeptName="Informatica", Designation="Scrum Master", Salary=3000 },
            };

            mockRepository.Setup(x => x.Get()).Returns(employeeList);
        
            ViewResult result = controller.Index() as ViewResult;

            var model = result.Model as List<EmployeeInfo>;

            mockRepository.Verify(x => x.Get(), Times.Once);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, model.Count);

        }
    }
}
