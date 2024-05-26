using QuanLyKhachSan.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKhachSan.Controllers.Public
{
    public class PublicHomeController : Controller
    {
        RoomDao roomDao = new RoomDao();
        ServiceDao serviceDao = new ServiceDao();
        TypeDao typeDao = new TypeDao();
        // GET: PublicHome
        public ActionResult Index()
        {
            ViewBag.ListRoom = roomDao.GetRoom();
            ViewBag.ListRoomDiscount = roomDao.GetRoomDiscount();
            ViewBag.ListService = serviceDao.GetServicesTop5();
            ViewBag.ListType = typeDao.GetTypes();
            ViewBag.active = "home";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.active = "contact";
            return View();
        }

        public ActionResult Event()
        {
            ViewBag.active = "event";
            return View();
        }

        public ActionResult Introduce()
        {
            ViewBag.active = "introduce";
            return View();
        }
    }
}