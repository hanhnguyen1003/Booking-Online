using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TransactionController : BaseController
    {
        public IActionResult Index()
        {
            return View(app.DetailTransaction.GetDetailTransactions());
        }
        public IActionResult Detail(string id)
        {
            return View(app.DetailTransaction.GetDetailTransactionById(id));
        }
    }
}
