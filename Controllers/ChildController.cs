using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FamilyFinance.Models;

namespace FamilyFinance.Controllers;

public class ChildController : Controller
{

    private FamilyFinanceContext db;
    public ChildController(FamilyFinanceContext context)
    {
        db = context;
    }

    // ========
    // GET CHILD DASHBOARD
    // ========
    [HttpGet("/familyfinance/child/dashboard")]
    public IActionResult Index()
    {
        return View("Index");
    }

}