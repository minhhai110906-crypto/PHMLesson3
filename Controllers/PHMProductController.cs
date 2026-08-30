using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using PHMLesson3.Models;

namespace PHMLesson3.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index(string category)
        {
            List<PHMAccount> products = new List<PHMAccount>
            {
                new PHMAccount() { Id = 1, Name = "Bộ đồ bơi cho trẻ em nam", Price = 35000, Category = "QuanAo", Avatar = Url.Content("~/Avatar/02.jfif"), Bio = "Đồ bơi chất lượng cao cho bé trai." },
                new PHMAccount() { Id = 2, Name = "Bộ đồ bơi cho trẻ em nữ", Price = 35000, Category = "QuanAo", Avatar = Url.Content("~/Avatar/03.jfif"), Bio = "Đồ bơi thiết kế dễ thương cho bé gái." },
                new PHMAccount() { Id = 3, Name = "Bộ đồ bơi trẻ em từ 3-5 tuổi", Price = 35000, Category = "QuanAo", Avatar = Url.Content("~/Avatar/04.jfif"), Bio = "Phù hợp cho trẻ nhỏ vận động dưới nước." },
                new PHMAccount() { Id = 4, Name = "Túi thời trang mẫu mới 2021", Price = 35000, Category = "TuiXach", Avatar = Url.Content("~/Avatar/02.jfif"), Bio = "Túi xách da cao cấp phong cách." },
                new PHMAccount() { Id = 5, Name = "Túi thời trang da cá sấu", Price = 35000, Category = "TuiXach", Avatar = Url.Content("~/Avatar/03.jfif"), Bio = "Túi da sang trọng đẳng cấp." }
            };

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category == category).ToList();
            }

            ViewBag.Accounts = products;
            return View();
        }

        public IActionResult Profile(int id = 1)
        {
            List<PHMAccount> products = new List<PHMAccount>
            {
                new PHMAccount() { Id = 1, Name = "Bộ đồ bơi cho trẻ em nam", Price = 35000, Category = "QuanAo", Avatar = Url.Content("~/Avatar/02.jfif"), Bio = "Đồ bơi chất lượng cao cho bé trai." },
                new PHMAccount() { Id = 2, Name = "Bộ đồ bơi cho trẻ em nữ", Price = 35000, Category = "QuanAo", Avatar = Url.Content("~/Avatar/03.jfif"), Bio = "Đồ bơi thiết kế dễ thương cho bé gái." },
                new PHMAccount() { Id = 3, Name = "Bộ đồ bơi trẻ em từ 3-5 tuổi", Price = 35000, Category = "QuanAo", Avatar = Url.Content("~/Avatar/04.jfif"), Bio = "Phù hợp cho trẻ nhỏ vận động dưới nước." },
                new PHMAccount() { Id = 4, Name = "Túi thời trang mẫu mới 2021", Price = 35000, Category = "TuiXach", Avatar = Url.Content("~/Avatar/02.jfif"), Bio = "Túi xách da cao cấp phong cách." },
                new PHMAccount() { Id = 5, Name = "Túi thời trang da cá sấu", Price = 35000, Category = "TuiXach", Avatar = Url.Content("~/Avatar/03.jfif"), Bio = "Túi da sang trọng đẳng cấp." }
            };

            PHMAccount product = products.FirstOrDefault(x => x.Id == id) ?? products.First();
            ViewBag.Account = product;
            return View();
        }
    }
}