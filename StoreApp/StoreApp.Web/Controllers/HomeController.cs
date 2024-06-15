using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers;

public class HomeController : Controller
{
    private IStoreRepository _storeRepository;

    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }
    
    public IActionResult Index()
    {
        var products = _storeRepository.Products.Select(x => new ProductViewModel{
            Id = x.Id,
            Name = x.Name,
            Category = x.Category,
            Description = x.Description,
            Price = x.Price
        }).ToList();

        return View(new ProductListViewModel {
            Products = products
        });
    }
}