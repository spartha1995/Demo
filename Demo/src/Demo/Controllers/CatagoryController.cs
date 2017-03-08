using Demo.Data;
using Demo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    public class CatagoryController : Controller
    {
        public ICatagory context { get; set; }
        public CatagoryController(ICatagory Catagoryname)
        {
            context = Catagoryname;
        }


        #region Get
        [HttpGet]
        public IEnumerable<Catagory> GetAll()
        {
            return context.GetAll();
        }

        #endregion


        #region post Method 
        [HttpPost]
        /// <summary>
        /// Post Method 
        /// Url:/api/Catagory
        /// /// </summary>
        /// <param name="catagoryname"></param>
        /// <returns></returns>
        public IActionResult AddCatagoryName([FromBody] Catagory catagoryname)
        {
            context.CatagoryAdd(catagoryname);
            return Ok();
        }
        #endregion

        #region PutMethod
        /// <summary>
        /// Put Method
        /// Url:/api/Catagory
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="catagoryname"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult UpdateCatagoryName(long Id, [FromBody] Catagory catagoryname)
        {
            var localobjectofcatagory = context.CatagoryFind(Id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            localobjectofcatagory.CatagoryName = catagoryname.CatagoryName;
            context.CatagoryUpdate(localobjectofcatagory);
            return Ok();
        }
        #endregion
    }
}
