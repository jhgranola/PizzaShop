using Microsoft.AspNetCore.Mvc;
using PizzaShop.Infrastructure;
using PizzaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;
        private Cart cart;

        public CartController(IProductRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,   //GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int productId, string returnURL)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                //Cart cart = GetCart();
                cart.AddItem(product, 1);
                //SaveCart(cart);
            }

            return RedirectToAction("Index", new { returnURL });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = repository.Products
                            .FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                //Cart cart = GetCart();
                cart.RemoveLine(product);
                //SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
            return cart;
        }
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }
    }
    
}
