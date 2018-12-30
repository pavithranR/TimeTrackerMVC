﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class ExpenseApprovalModel
    {
        public int ExpenseID { get; set; }
        public string Comment { get; set; }
    }

    public class TimeSheetApproval
    {
        public int TimeSheetMasterID { get; set; }
        public string Comment { get; set; }
    }
}
