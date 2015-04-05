using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProjects2.Models;

namespace TeamProjects2.Controllers
{
    public class RequestController : Controller
    {
        [Authorize]
        public ActionResult MakeRequest()
        {
            return View();
        }

        [Authorize]
        public ActionResult ViewRequest()
        {
            IList<ViewRequest> oRequestID = null;
            using (team07Entities oteam07ViewRequest = new team07Entities())
            {
                oRequestID = (from Request in oteam07ViewRequest.Requests
                                join Modules in oteam07ViewRequest.Modules
                                on Request.moduleCode equals Modules.moduleCode
                                join WeekView in oteam07ViewRequest.Weeks
                                on Request.weekID equals WeekView.weekID
                                select new ViewRequest()
                                {
                                    requestID = Request.requestID,
                                    status = Request.status,
                                    day = Request.day,
                                    periodStart =Request.periodStart,
                                    periodEnd = Request.periodEnd,
                                    semester = Request.semester,
                                    year =Request.year,
                                    round = Request.round,
                                    moduleCode = Modules.moduleCode,
                                    moduleTitle = Modules.moduleTitle,
                                    week1 = WeekView.week1,
                                    week2 = WeekView.week2,
                                    week3 = WeekView.week3,
                                    week4 = WeekView.week4,
                                    week5 = WeekView.week5,
                                    week6 = WeekView.week6,
                                    week7 = WeekView.week7,
                                    week8 = WeekView.week8,
                                    week9 = WeekView.week9,
                                    week10 = WeekView.week10,
                                    week11 = WeekView.week11,
                                    week12 = WeekView.week12,
                                    week13 = WeekView.week13,
                                    week14 = WeekView.week14,
                                    week15 = WeekView.week15

                                }).ToList(); //putting the table User into variable called oUser ---- query called linq 
            }
            return View(oRequestID);
        }
    }
}
