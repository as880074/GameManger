using Microsoft.AspNetCore.Mvc;

namespace GameManagement.Controllers;

public class TransactionsController : Controller
{
    /*
    private readonly AppDbContext _context;

    public TransactionsController(AppDbContext context)
    {
        _context = context;
    }

    // 交易紀錄列表
    public IActionResult Index()
    {
        var transactions = _context.Transactions.ToList();
        return View(transactions);
    }

    // 顯示單筆交易細節
    public IActionResult Details(int id)
    {
        var transaction = _context.Transactions.Find(id);
        if (transaction == null) return NotFound();
        return View(transaction);
    }
    */
}