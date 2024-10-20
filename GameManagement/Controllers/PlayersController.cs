using Microsoft.AspNetCore.Mvc;

namespace GameManagement.Controllers;

public class PlayersController : Controller
{
    /*
    private readonly AppDbContext _context;

    public PlayersController(AppDbContext context)
    {
        _context = context;
    }

    // 玩家列表
    public IActionResult Index()
    {
        var players = _context.Players.ToList();
        return View(players);
    }

    // 顯示單個玩家細節
    public IActionResult Details(int id)
    {
        var player = _context.Players.Find(id);
        if (player == null) return NotFound();
        return View(player);
    }

    // 新增玩家頁面
    public IActionResult Create()
    {
        return View();
    }

    // 新增玩家（POST）
    [HttpPost]
    public IActionResult Create(Player player)
    {
        if (ModelState.IsValid)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        return View(player);
    }

    // 編輯玩家頁面
    public IActionResult Edit(int id)
    {
        var player = _context.Players.Find(id);
        if (player == null) return NotFound();
        return View(player);
    }

    // 編輯玩家（POST）
    [HttpPost]
    public IActionResult Edit(Player player)
    {
        if (ModelState.IsValid)
        {
            _context.Players.Update(player);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        return View(player);
    }

    // 刪除玩家
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var player = _context.Players.Find(id);
        if (player == null) return NotFound();

        _context.Players.Remove(player);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    */
}