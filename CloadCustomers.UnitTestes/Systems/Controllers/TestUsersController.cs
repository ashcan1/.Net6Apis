using System.Threading.Tasks;
using Xunit;
using CloadCustomers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;


namespace CloadCustomers.UnitTestes.Systems.Controllers;

public class TestUsersController 
{
    [Fact]
    public async Task Get_Onsuccess_ReturnStatusCode200()
    {
        // Arrange 

        var sut = new UserController();

        // Act 
        var result = (OkObjectResult)await sut.Get();

        //Assert

        result.StatusCode.Should().Be(200);


    }
}

