using GameManagement.Models;
using GameManagement.Repority;
using Microsoft.AspNetCore.Mvc;

namespace GameManagement.Controllers;

public class GameController : Controller
{
    private readonly AppDbContext _context;
/*
    public GamesController(AppDbContext context)
    {
        _context = context;
    }
*/
    // 列表頁面
    public IActionResult Index()
    {
        var games = new List<Game>
        {
            new Game { Id = 1, Name = "遊戲1", Merchant = "商家1", GameType = "遊戲類型1", UserId = "使用者1", Email = "使用者", CreatedAt = DateTime.Now, Status = "狀態1", Remarks = "備註1" },
        };
        return View(games);
        /*
        var games = _context.Games.ToList();
        return View(games);*/
    }

    // 新增遊戲頁面
    public IActionResult Create()
    {
        return View();
    }

    // 新增遊戲 POST 請求
    [HttpPost]
    public IActionResult Create(Game game)
    {
        if (ModelState.IsValid)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(game);
    }

    // 編輯遊戲頁面
    public IActionResult Edit(int id)
    {
        /*
        var game = _context.Games.Find(id);
        if (game == null) return NotFound();*/
        var game = new Game
        {
            Id = 1, Name = "遊戲1", Merchant = "商家1", GameType = "遊戲類型1", UserId = "使用者1", Email = "使用者",
            CreatedAt = DateTime.Now, Status = "狀態1", Remarks = "備註1"
        };
        return View(game);
    }

    // 編輯遊戲 POST 請求
    [HttpPost]
    public IActionResult Edit(Game game)
    {
        if (ModelState.IsValid)
        {
            _context.Games.Update(game);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(game);
    }

    // 刪除遊戲
    public IActionResult Delete(int id)
    {
        var game = _context.Games.Find(id);
        if (game == null) return NotFound();

        _context.Games.Remove(game);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    // 檢視遊戲詳細頁面
    public IActionResult Details(int id)
    {
        // 模擬資料庫查詢，這裡應該換成真實資料庫的查詢
        var game = new Game
        {
            Id = 1, Name = "遊戲1", Merchant = "商家1", GameType = "遊戲類型1", UserId = "使用者1", Email = "使用者",
            CreatedAt = DateTime.Now, Status = "狀態1", Remarks = "備註1"
        };
    
        // 如果找不到遊戲，返回 404 錯誤
        if (game == null) return NotFound();

        return View(game);
    }
}