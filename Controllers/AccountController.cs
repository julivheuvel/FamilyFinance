using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FamilyFinance.Models;

namespace FamilyFinance.Controllers;

public class AccountController : Controller
{

    private FamilyFinanceContext db;
    public AccountController(FamilyFinanceContext context)
    {
        db = context;
    }

    // ========
    // GET CHILD DASHBOARD
    // ========


}