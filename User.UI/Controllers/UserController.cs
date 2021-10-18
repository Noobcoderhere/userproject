using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using User.App.Service;
using User.App.ViewModel;
using User.Domain.Model;

namespace User.UI.Controllers
{

    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var response = await _userService.GetUsers();
            return View(response);
        }

        [HttpGet]
        public async Task<ActionResult> CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([Bind(include: "Name,Age")] TestUser user)
        {
            try
            {
                await _userService.AddUser(user);
            }
            catch (DbUpdateException dbuex)
            {
                return BadRequest(dbuex.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> UserDetail(int id)
        {
            var response = await _userService.GetUserById(id);
            if (response == null)
            {
                ViewBag.Message = string.Format("Not Found");
                return NotFound();
            }
            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser(int id)
        {
            var response = await _userService.GetUserById(id);
            if (response == null)
            {
                return NotFound();
            }
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(TestUser user)
        {
            try
            {
                await _userService.UpdateUser(user);
            }
            catch (DbUpdateException dbuex)
            {
                return BadRequest(dbuex.Message);
            }
            return RedirectToAction("UserDetail", new { id = user.Id });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var response = await _userService.GetUserById(id);
            if (response == null)
            {
                return NotFound();
            }
            return View(response);
        }

        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _userService.DeleteUser(id);
            }
            catch (DbUpdateException dbuex)
            {
                return BadRequest(dbuex.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
