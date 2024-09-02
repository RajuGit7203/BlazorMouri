using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mouri.Shared;
using System.Net;

namespace Mouri.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientData _patientRepository;
        public PatientController(IPatientData patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet()]
        [Authorize]
        [Route("GetPatient/{id}")]
        public async Task<Patient> GetPatient(string id)
        {
           
            return await  _patientRepository.GetPatient(id);


        }


    }
}
