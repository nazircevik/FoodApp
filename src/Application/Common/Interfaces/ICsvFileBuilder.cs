using FoodApp.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace FoodApp.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
