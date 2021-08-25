using ElevenNote.Data;
using ElevenNote.WebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ElevenNote.WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ApplicationDbContext _userId = new ApplicationDbContext();
        [HttpPost]
        public async Task<IHttpActionResult> CreateCategory([FromBody] Category model)
        {
            if (model is null)
                return BadRequest("Your request body cannot be empty.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //Find the note by model.CategoryId and see that it exits
            var noteEntity = await _userId.Categories.FindAsync(model.CategoryId);
            if (noteEntity is null)
                return BadRequest($"The target note with the ID of {model.CategoryId} does not exit.");

            //_userId.Categories.Add(model);
            noteEntity.Categories.Add(model);
            if (await _userId.SaveChangesAsync() == 1) ;
            return Ok($"You created a Category {model.CategoryId} successfully");
            return InternalServerError();

        }
    }
}
