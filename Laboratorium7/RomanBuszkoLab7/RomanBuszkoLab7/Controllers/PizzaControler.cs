using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RomanBuszkoLab7.Models;
using RomanBuszkoLab7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanBuszkoLab7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaControler : ControllerBase
    {
        private IPizzaService _pizzaService;

        public PizzaControler(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        /// <summary>
        /// Zwraca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var pizzas = _pizzaService.Get();
            return Ok(pizzas);
        }
        /// <summary>
        /// Dodaj nową pizzę
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Pizza pizza)
        {
            int id = _pizzaService.Post(pizza);
            return Ok(pizza);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Pizza pizza, [FromRoute] int id)
        {
            if (id != pizza.Id)
            {
                return Conflict("Podane Id są różne");
            }
            else
            {
                var isUpdateSuccesful = _pizzaService.Put(pizza, id);

                if (isUpdateSuccesful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _pizzaService.Delete(id);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
