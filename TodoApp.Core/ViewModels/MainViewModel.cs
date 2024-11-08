using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Interfaces;
using TodoApp.Core.Models;

namespace TodoApp.Core.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private IRepository _repository;

        public MainViewModel(IRepository repository)
        {
            _repository = repository;
        }

        public string Title => "TodoApp";


        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddTodoCommand))]
        private string _todoTitle = string.Empty;

        [ObservableProperty]
        private ObservableCollection<Todo> _todos = new();

        private bool CanAdd => this.TodoTitle.Length  > 0;

        [RelayCommand(CanExecute = nameof(CanAdd))]
        void AddTodo()
        {

                Todo todo = new(TodoTitle);
                _repository.Add(todo);
                Todos.Add(todo);

                // text entry should be empty
                this.TodoTitle = string.Empty;
        }

        [RelayCommand]
        void AddTodoItem(Todo todo)
        {

            _repository.Add(todo);
            Todos.Add(todo);
        }

        [RelayCommand]
        void LoadData()
        {
            _todos.Clear();

            var todos = _repository.GetAll();

            foreach (var todo in todos)
            {
                _todos.Add(todo);
            }
        }
    }
}
