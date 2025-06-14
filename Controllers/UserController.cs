using Microsoft.AspNetCore.Mvc;
using MyApi.Data;
using MyApi.Models;

namespace MyApi.Controllers
{

	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		private readonly AppDbContext _context;

		public UserController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/user
		[HttpGet]
		public ActionResult<IEnumerable<User>> GetAll() => Ok(_context.Users.ToList());

		// GET: api/user/1
		[HttpGet("{id}")]
		public ActionResult<User> GetById(int id)
		{
			var user = _context.Users.Find(id);
			return user == null ? NotFound() : Ok(user);
		}

		// POST: api/user
		[HttpPost]
		public ActionResult<User> Create(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
			return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
		}

		// PUT: api/user/1
		[HttpPut("{id}")]
		public IActionResult Update(int id, User updatedUser)
		{
			var user = _context.Users.Find(id);
			if (user == null) return NotFound();

			user.Name = updatedUser.Name;
			_context.SaveChanges();
			return NoContent();
		}

		// DELETE: api/user/1
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var user = _context.Users.Find(id);
			if (user == null) return NotFound();

			_context.Users.Remove(user);
			_context.SaveChanges();
			return NoContent();
		}
	}
}