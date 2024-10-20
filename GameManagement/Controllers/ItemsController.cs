using Microsoft.AspNetCore.Mvc;

namespace GameManagement.Controllers;

public class ItemsController : Controller
{
    /*
    private readonly AppDbContext _context;

    public ItemsController(AppDbContext context)
    {
        _context = context;
    }

    // 點數品項列表
    public IActionResult Index()
    {
        var items = _context.Items.ToList();
        return View(items);
    }

    // 顯示單個品項細節
    public IActionResult Details(int id)
    {
        var item = _context.Items.Find(id);
        if (item == null) return NotFound();
        return View(item);
    }

    // 新增品項頁面
    public IActionResult Create()
    {
        return View();
    }

    // 新增品項（POST）
    [HttpPost]
    public IActionResult Create(Item item)
    {
        if (ModelState.IsValid)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(item);
    }

    // 編輯品項頁面
    public IActionResult Edit(int id)
    {
        var item = _context.Items.Find(id);
        if (item == null) return NotFound();
        return View(item);
    }

    // 編輯品項（POST）
    [HttpPost]
    public IActionResult Edit(Item item)
    {
        if (ModelState.IsValid)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(item);
    }

    // 刪除品項
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var item = _context.Items.Find(id);
        if (item == null) return NotFound();

        _context.Items.Remove(item);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    */
}