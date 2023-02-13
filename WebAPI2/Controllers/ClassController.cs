using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Data;
using WebAPI2.Model;
using WebAPI2.Model.dto;
using WebAPI2.Services;
using WebAPI2.Services.Impl;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _classRepository;

        public ClassController(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllClasses()
        {
            return Ok(_classRepository.GetAll());
        }

        [HttpGet("Search")]
        public IActionResult GetClassesbyID(int id)
        {
            try
            {
                var data = _classRepository.GetClassbyId(id);
                if(data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
                
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CreateClass(ClassModel model1)
        {
            try
            {
                return Ok(_classRepository.Create(model1));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateClass(int id, ClassDto model1)
        {
            if(id != model1.classid)
            {
                return NotFound();
            }
            try
            {
                _classRepository.Update(model1);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClass(int id)
        {
            try
            {
                _classRepository.Delete(id);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }


    }
}
