using CMS.WebApp.DatabaseContext;
using CMS.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMS.WebApp.Controllers;

public class CustomerController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public CustomerController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public async Task<ActionResult<Customer>> Index()
    {
        var data = await _dbContext.Set<Customer>().AsNoTracking().ToListAsync();
        return View(data);

    }
    public async Task<ActionResult<Customer>>CreateOrEdit(int id)
    {
        if (id == 0)
        {
            return View();
        }
        else
        {
            var data= await _dbContext.Set<Customer>().FindAsync(id);
            return View(data);
        }
    }

    [HttpPost]

    public async Task<ActionResult<Customer>> CreateOrEdit(int id, Customer customer)
    {
        if (id == 0)
        {
            if(ModelState.IsValid)
            {
                await _dbContext.Set<Customer>().AddAsync(customer);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

        }
        else
        {
            return RedirectToAction("Index");
        }
        return RedirectToAction("Index");
    }


}
