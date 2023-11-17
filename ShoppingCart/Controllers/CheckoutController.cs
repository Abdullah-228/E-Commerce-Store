using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Infrastructure;
using ShoppingCart.Models;
using ShoppingCart.Models.ViewModels;

public class CheckoutController : Controller
{
    private readonly DataContext _context;

    public CheckoutController(DataContext context)
    {
        _context = context;
    }
    public IActionResult Confirmation()
    {
 
        return View();
    }

    //public IActionResult fromm()
    //{
    //    List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();


    //    CartViewModel cartVM = new()
    //    {
    //        CartItems = cart,
    //        GrandTotal = cart.Sum(x => x.Quantity * x.Price)
    //    };

    //    return View("Index", cartVM);
    //}

    //// Handle the form submission
    //[HttpPost]
    //public IActionResult Index(CheckoutViewModel model)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        // Process the checkout and save the order
    //        // You can add your business logic here

    //        return RedirectToAction("Confirmation");
    //    }

    //    return View(model);
    //}

    // Display a confirmation page

}
