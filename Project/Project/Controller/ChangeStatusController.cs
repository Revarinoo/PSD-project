using Project.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class ChangeStatusController
    {
        public static void ChangeStatus(int id)
        {
            ChangeStatusHandler.ChangeStatus(id);
        }
    }
}