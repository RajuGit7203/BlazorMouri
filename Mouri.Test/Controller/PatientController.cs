using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Moq;
using Mouri.Api.Controllers;
using Mouri.Shared;
using Mouri.Test.MockData;
using Mouri_Api.Controllers;
using Mouri_Api.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouri.Test.Controller
{
    public class PatientControllerTest
    {
        [Fact]
        public async Task Patient_GetPatient_Verify()
        {
            ///Arange
            var patService = new Mock<IPatientData>();
            var id = ToDoMockData.PatientId;
            var sut = new PatientController(patService.Object);

            ///Act
            var result = await sut.GetPatient(id);

            ///Assert
            patService.Verify(_ => _.GetPatient(id), Times.Exactly(1));



        }
    }
}
