﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackTest.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FullStackTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;

        private readonly ILogger<StatisticsController> _logger;

        public StatisticsController(ILogger<StatisticsController> logger, IStatisticsService calculatorService)
        {
            _logger = logger;
            _statisticsService = calculatorService;
        }

        [HttpGet]
        public IActionResult Sum([FromQuery] int[] inputs)
        {
            return Ok(_statisticsService.Sum(inputs));
        }
    }

}
