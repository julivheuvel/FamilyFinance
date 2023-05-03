using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FamilyFinance.Models;

namespace FamilyFinance.Controllers;

public class ParentController : Controller
{

    private FamilyFinanceContext db;
    public ParentController(FamilyFinanceContext context)
    {
        db = context;
    }

    // ========
    // GET PARENT DASHBOARD
    // ========
    [HttpGet("/familyfinance/parent/dashboard")]
    public IActionResult Index()
    {
        return View("Index");
    }

}