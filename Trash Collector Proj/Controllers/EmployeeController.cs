using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trash_Collector_Proj.Data;
using Trash_Collector_Proj.Models;

namespace Trash_Collector_Proj.Controllers
{
    public class EmployeeController : Controller
    {
        public double pricePerPickup = 5;
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Home()
        {
            return View();
        }

        // GET: Employee
        public async Task<IActionResult> Index(string searchDay)
        {
            ResetPickUp();
            string dayOfWeek;
            string extraDay;
            int date = DateTime.Today.DayOfYear;
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            if (employee == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                ViewData["CurrentFilter"] = searchDay;
                ViewBag.Day = searchDay;
                if(searchDay == "Today" || searchDay == null)
                {
                    dayOfWeek = DateTime.Today.DayOfWeek.ToString();
                    var customers = _context.Customers.Where(c => c.Zipcode == employee.Zipcode && c.WeekDay.Name == dayOfWeek && c.StartDate <= DateTime.Today && c.EndDate >= DateTime.Today && c.TrashPickedUp == false).Include(c => c.WeekDay).ToList();
                    var extraDayCustomers = _context.Customers.Where(c => c.Zipcode == employee.Zipcode && c.StartDate <= DateTime.Today && c.EndDate >= DateTime.Today).Include(c => c.WeekDay).ToList();
                    foreach (var person in extraDayCustomers)
                    {
                        if (person.ExtraPickUp.HasValue)
                        {
                            if (person.ExtraPickUp.Value.DayOfYear == date)
                            {
                                customers.Add(person);
                                person.ExtraPickUp = null;
                            }
                        }
                    }
                    return View(customers);
                }
                else
                {
                    dayOfWeek = searchDay;
                    extraDay = searchDay;
                    var filteredCustomers = _context.Customers.Where(c => c.Zipcode == employee.Zipcode && c.WeekDay.Name == dayOfWeek).Include(c => c.WeekDay).ToList();
                    var extraDayCustomers = _context.Customers.Where(c => c.Zipcode == employee.Zipcode).Include(c => c.WeekDay).ToList();
                    foreach (var person in extraDayCustomers)
                    {                       
                        if (person.ExtraPickUp.HasValue)
                        {
                            if (person.ExtraPickUp.Value.DayOfWeek.ToString() == searchDay)
                            {
                                filteredCustomers.Add(person);
                                person.ExtraPickUp = null;
                            }
                        }
                    }
                    return View(filteredCustomers);
                }
               
            }
        }
        public IActionResult Map(int? id)
        {
            var customer = _context.Customers.Find(id);
            ViewBag.Address = customer.Address;
            return View();
        }
        public IActionResult ResetPickUp()
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan difference;
            var customers = _context.Customers.Select(c => c).ToList();
            foreach (var person in customers)
            {
                difference = dateTime - person.PickUpTIme;
                if (difference.Days >= 1)
                {
                    person.TrashPickedUp = false;
                    _context.Update(person);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult ChargeCustomer(int? Id)
        {
            var customer = _context.Customers.Find(Id);
            customer.PickUpTIme = DateTime.Today;
            customer.Balance = customer.Balance + pricePerPickup;
            customer.TrashPickedUp = true;
            _context.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> CustomerDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .Include(c => c.WeekDay)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Include(e => e.IdentityUser).FirstOrDefault(c => c.IdentityUserId == userId);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Zipcode,IdentityUserId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Zipcode,IdentityUserId")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    employee.IdentityUserId = userId;
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
