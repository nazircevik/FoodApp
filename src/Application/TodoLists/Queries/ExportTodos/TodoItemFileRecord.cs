using FoodApp.Application.Common.Mappings;
using FoodApp.Domain.Entities;

namespace FoodApp.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
