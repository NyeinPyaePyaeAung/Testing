// YourController.cs

using Microsoft.AspNetCore.Mvc;
using vindly.Data;
using vindly.Models; // Assuming "vindly.Models" namespace contains your database entities

public class CategoryController : Controller
{
    private readonly ApplicationDbContext dbContext; // Replace "YourDbContext" with your actual database context class

    public CategoryController(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext; // Inject the database context via constructor injection
    }

    // Action method for the "/Plus" route
    public IActionResult Plus(int id)
    {
        // Find the item in the database by its ID
        var originalItem = dbContext.Category.Find(id);
        if (originalItem == null)
        {
            return NotFound();
        }

        // Create a new item with the same properties as the original item
        var newItem = new Category
        {
            Name = originalItem.Name,
            PM = originalItem.PM,
            RD = originalItem.RD,
            UT = originalItem.UT,
            OT = originalItem.OT
        };

        // Add the new item to the database
        dbContext.Category.Add(newItem);
        dbContext.SaveChanges();

        // Redirect back to the original page
        return RedirectToAction("Index");
    }

    // Action method for the "/Minus" route
    public IActionResult Minus(int id)
    {
        // Find the item in the database and remove it
        var itemToRemove = dbContext.Category.Find(id);
        if (itemToRemove != null)
        {
            dbContext.Category.Remove(itemToRemove);
            dbContext.SaveChanges();
        }

        // Redirect back to the original page
        return RedirectToAction("Index");
    }

    // Your existing action method for the page
    public IActionResult Index()
    {
        // Retrieve the model data from the database and pass it to the view
        var model = dbContext.Category;
        return View(model);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            dbContext.Dispose(); // Dispose the database context
        }
        base.Dispose(disposing);
    }
}
