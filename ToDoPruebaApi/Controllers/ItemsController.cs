using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ToDoPruebaApi.Entities;
using ToDoPruebaApi.Services;

namespace ToDoPruebaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IService<Item> _itemsService;
        public ItemsController(IService<Item> service)
        {
            _itemsService = service;
        }
        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
            return _itemsService.GetAll();
        }
        [HttpGet("{id}")]
        public Item GetById([FromRoute] Guid id)
        {
            return _itemsService.GetById(id);
        }
        [HttpPost]
        public IActionResult Add([FromBody] Item item)
        {
            _itemsService.Add(item);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Item item, Guid id)
        {
            _itemsService.Update(item, id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            _itemsService.Delete(id);
            return Ok();
        }
    }
}
