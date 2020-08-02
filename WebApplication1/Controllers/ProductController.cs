using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using ProductApp.Repository;

namespace ProductApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repo;
        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        [Route("AddItems")]
        public IActionResult AddItems(Products obj)
        {
            try
            {
                _repo.AddItems(obj);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }

        }

    [HttpPut]
    [Route("UpdateItem")]
    public IActionResult UpdateItem(Products obj)
    {
        try
        {
            _repo.UpdateItem(obj);
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound(e.InnerException.Message);
        }
    }
        [HttpGet]
        [Route("GetItem/{id}")]
        public IActionResult GetItem(int id)
        {
            try
            {

                return Ok(_repo.GetItem(id));
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult DeleteItem(int id)
        {
            try
            {
                _repo.DeleteItem(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpGet]
        [Route("ViewItems")]
        public IActionResult ViewItem()
        {
            try
            {
                return Ok(_repo.ViewItems());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}