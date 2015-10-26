using Core.Biz;
using Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebForm.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<User> users = UserContext.getAll();
            return View(users);
        }

        public ActionResult Login()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public ActionResult Login(User model)
        {
            //Kiểm tra điều kiện đăng nhập
            if(String.IsNullOrEmpty(model.Username) || String.IsNullOrEmpty(model.Password))
            {
                return View(model);
            }
            //Tìm kiếm user
            User user = UserContext.find(model.Username);
            //Nếu người dùng không tồn tại
            if(user == null) { return RedirectToAction("login"); }
            //Kiểm tra mật khẩu
            if (user.login(model.Password))
            {
                return RedirectToAction("index");
            }
            return RedirectToAction("login");
        }
        public ActionResult Details(string username)
        {
            if (username == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = UserContext.find(username);
            if (user == null)
            { 
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult Edit(string username = null)
        {
            if (username == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = UserContext.find(username);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (UserContext.update(model) == 0)
            {
                return View(model);
            }

            return RedirectToAction("Details",new {username = model.Username});
        }
    }
}