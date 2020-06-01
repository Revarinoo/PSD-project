using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class ChangeStatusHandler
    {
        public static void ChangeStatus(int id)
        {
            UserRepository.changeStatus(id);
        }
    }
}