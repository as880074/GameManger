using GameManagement.Repority;
using Microsoft.AspNetCore.Mvc;

namespace GameManagement.Controllers;

public class TransfersController : Controller
{
    /*
    private readonly AppDbContext _context;

    public TransfersController(AppDbContext context)
    {
        _context = context;
    }

    // 轉帳紀錄列表
    public IActionResult Index()
    {
        var transfers = _context.Transfers.ToList();
        return View(transfers);
    }

    // 顯示單筆轉帳紀錄細節
    public IActionResult Details(int id)
    {
        var transfer = _context.Transfers.Find(id);
        if (transfer == null) return NotFound();
        return View(transfer);
    }
    */
}