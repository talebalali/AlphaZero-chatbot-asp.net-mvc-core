using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaZero.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace AlphaZero.Data.ViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            return View(items.Count);
        }
    }
}
