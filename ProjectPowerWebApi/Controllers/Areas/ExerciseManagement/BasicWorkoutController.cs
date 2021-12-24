using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectPower.Areas.A2S_Program.Models.BaseWorkoutInformationService;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.UserAccounts.Models.UserAccounts;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ProjectPowerWebApi.Controllers.Areas.Users
{
    [ApiController]
    [Route("[controller]")]
    public class BasicWorkoutController : ControllerBase
    {
        private readonly ILogger<BasicWorkoutController> _logger;
        private readonly IBasicWorkoutInformationService _service;

        public BasicWorkoutController(IBasicWorkoutInformationService service, ILogger<BasicWorkoutController> logger)
        {
            _logger = logger;
            _service = service;
        }




    }
}
