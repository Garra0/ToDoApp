using System.Collections.Generic;

namespace TodoApp.Web.Pages;

public class IndexModel : TodoAppPageModel
{
    public List<TodoItemDto> TodoItems { get; set; }
    private readonly ITodoAppService _todoAppService;
    public IndexModel(ITodoAppService todoAppService)
    {
        _todoAppService = todoAppService;
    }
    public async void OnGetAsync()
    {
        TodoItems = await _todoAppService.GetListAsync();
    }
}
