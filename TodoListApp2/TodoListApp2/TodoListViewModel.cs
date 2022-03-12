using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TodoListApp2
{
    class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }


        public TodoListViewModel()
        {
            this.TodoItems = new ObservableCollection<TodoItem>();

            this.TodoItems.Add(new TodoItem("Todo 1", false));
            this.TodoItems.Add(new TodoItem("Todo 2", false));
            this.TodoItems.Add(new TodoItem("Todo 3", false));
        }

        public ICommand AddTodoCommand => new Command(addTodoItem);
        public string NewTodoInputValue { get; set; }
        public void addTodoItem()
        {
            TodoItem todoItem = new TodoItem(NewTodoInputValue, false);
            this.TodoItems.Add(todoItem);
        }

        public void remove()
        {

        }

        public void toggle()
        {

        }
    }
}
