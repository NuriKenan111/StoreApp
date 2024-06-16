using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers;

public class HomeController : Controller
{
    private IStoreRepository _storeRepository;
    public int pageSize = 3;
    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }
    
    public IActionResult Index(int page = 1)
    {
        var products = _storeRepository
        .Products
        .Skip((page - 1) * pageSize)
        .Select(x => new ProductViewModel{
            Id = x.Id,
            Name = x.Name,
            Category = x.Category,
            Description = x.Description,
            Price = x.Price
        }).Take(pageSize);

        return View(new ProductListViewModel {
            Products = products,
            PageInfo = new PageInfo {
                ItemsPerPage = pageSize,
                TotalItems = _storeRepository.Products.Count()
            }
        });
    }
}