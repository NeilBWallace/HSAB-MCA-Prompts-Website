using Mental_Capacity_Assessments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Mental_Capacity_Assessments.Controllers
{
    public class HomeController : Controller
    {

        private Mental_Capacity_AssessmentsContext db = new Mental_Capacity_AssessmentsContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Information()
        {
            return View();
        }


        public ActionResult Index2()
        {
            //   return View(await _context.Questions.ToListAsync());


            if (Globals.Current_Page == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questions questions = db.Questions.Find(Globals.Current_Page);
            if (questions == null)
            {
                return HttpNotFound();
            }
            Globals.Yes_Next = questions.yes_next;
            Globals.No_Next = questions.no_next;
            Globals.Yes_Button = questions.yes_button;
            Globals.No_Button = questions.no_button;
            Globals.Display_Text = questions.Description;
            if (Globals.FirstTime == "1")
            {
                Globals.Message = "hello";
                Globals.FirstTime = "0";
            }
                return View(questions);
            }
     

        // GET: Questions/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questions questions = db.Questions.Find(id);
            if (questions == null)
            {
                return HttpNotFound();
            }

            //   return View(await _context.Questions.ToListAsync());
            if (id == "1") { Globals.Section = "Assessing Capacity Prompts"; };
            if (id == "22") { Globals.Section = "Best Interest Decisions Prompts"; };
            if (id == "38") { Globals.Section = "IMCA Referrals"; };
            if (id == "42") { Globals.Section = "DOLS Applications"; };

            Globals.Yes_Next = questions.yes_next;
            Globals.No_Next = questions.no_next;
            Globals.Yes_Button = questions.yes_button;
            Globals.No_Button = questions.no_button;
            Globals.Display_Text = questions.Description;

            return View(questions);
        }



    
    }
}