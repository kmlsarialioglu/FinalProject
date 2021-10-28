using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupliersController : ControllerBase
    {
        private ISuplierService _suplierService;
        public SupliersController(ISuplierService suplierService)
        {
            _suplierService = suplierService;
        }

        [HttpGet]
        public IActionResult Get(long Id)
        {
            var result = _suplierService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Post(Suplier suplier)
        {
            var result = _suplierService.Add(suplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut]
        public IActionResult Put(Suplier suplier)
        {
            var result = _suplierService.Update(suplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        public IActionResult Delete(Suplier suplier)
        {
            var result = _suplierService.Delete(suplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
