using Moq;
using Mouri.Test.MockData;
using Mouri_Api.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mouri_Api.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace Mouri.Test.Controller
{
    public class UserControllerTest
    {
        [Fact]
        public async Task Token_ShouldRetrun_Null()
        {
            ///Arange
            var userService = new Mock<IUserService>();
            _ = userService.Setup(_ => _.Login(ToDoMockData.GetUser()));
            var sut = new UserController(userService.Object);

            ///Act
            var result=  sut.Token;

            ///Assert
             result.GetType().Should().NotBeNull();            
           



        }

    }
}
