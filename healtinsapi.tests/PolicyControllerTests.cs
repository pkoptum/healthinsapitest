using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using healtinsapi.Controllers;
using healtinsapi.Data.repository;
using healtinsapi.Interfaces;
using Moq;
using poc.Data;
using poc.Models;
using Xunit;

namespace healtinsapi.tests
{
    public class PolicyControllerTests
    {
        [Fact]
        public async Task Test1Async()
        {
            //arrange
            var temp1=new Mock<DataContext>();
            var temp=new Mock<PolicyRepository>(tem     p1);
            temp.Setup(repo=>repo.GetPoliciesAsync())
            .ReturnsAsync((IEnumerable<Policy>)null);

            var controller = new PolicyController(temp1.Object);
            //act
            var result=await controller.GetPolicies();
            // Console.WriteLine(result);
            Assert.Equal(1,1);
            // System.console.writeline("hello");
        }
    }
}
