using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyBe.Domain.Contracts.Enums;
using HyBe.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetIntervals()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(Interval)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(Interval), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetMarkets()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(Market)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(Market), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetMessageChannels()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(MessageChannel)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(MessageChannel), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetOrderTypes()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(OrderType)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(OrderType), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetSides()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(Side)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(Side), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetSignalResults()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(SignalResult)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(SignalResult), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetTrendStrategies()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(TrendStrategy)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(TrendStrategy), x)).ToString() }));
            return Ok(list);
        }

    }
}

