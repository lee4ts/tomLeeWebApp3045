using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TomLeeWebApp3045.Models;

namespace TomLeeWebApp3045.Controllers;

/*
@TODO
integrate database - categorized / uncategorized
-> all should update the database.
*/
public class CategoriesController : Controller
{
    public IActionResult Index()
    {
        var categories = CategoriesRepo.GetAllCategories();
        return View(categories);
    }
    
    // -------- ADD CATEGORY --------
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Category category)
    {
        if (ModelState.IsValid)
        {
            CategoriesRepo.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }
        return View(category);
    }


    // -------- EDIT CATEGORY --------
    public IActionResult Edit([FromRoute] int? id)
    {
        var category = CategoriesRepo.GetCategoryById(id ?? 0);
        return View(category);
    }

    [HttpPatch]
    public IActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {
            CategoriesRepo.UpdateCategory(category.CategoryId, category);
            return RedirectToAction(nameof(Index));
        }
        return View(category);
    }

    // -------- DELETE CATEGORY --------
    public IActionResult Delete([FromRoute] int? id)
    {
        var category = CategoriesRepo.GetCategoryById(id ?? 0);
        return View(category);
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        CategoriesRepo.DeleteCategory(id);
        return RedirectToAction(nameof(Index));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}