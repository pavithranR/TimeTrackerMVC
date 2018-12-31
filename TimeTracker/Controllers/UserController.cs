using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTracker.Concrete;
using TimeTracker.Filters;
using TimeTracker.Interface;

namespace TimeTracker.Controllers
{
    [ValidateUserSession]
    public class UserController : Controller
    {
        private ITimeSheet _ITimeSheet;
        //private IExpense _IExpense;

        public UserController()
        {
            _ITimeSheet = new TimeSheetConcrete();
           // _IExpense = new ExpenseConcrete();
        }


        // GET: User
        [HttpGet]
        public ActionResult Dashboard()
        {
            //var timesheetResult = _ITimeSheet.GetTimeSheetsCountByUserID(Convert.ToString(Session["UserID"]));

            //if (timesheetResult != null)
            //{
            //    ViewBag.SubmittedTimesheetCount = timesheetResult.SubmittedCount;
            //    ViewBag.ApprovedTimesheetCount = timesheetResult.ApprovedCount;
            //    ViewBag.RejectedTimesheetCount = timesheetResult.RejectedCount;
            //}
            //else
            //{
            //    ViewBag.SubmittedTimesheetCount = 0;
            //    ViewBag.ApprovedTimesheetCount = 0;
            //    ViewBag.RejectedTimesheetCount = 0;
            //}
            
            return View();
        }

    }
}