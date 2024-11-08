using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Interfaces;
using TodoApp.Core.Models;

namespace TodoApp.TodoData
{
    public class StaticData : IRepository
    {
        List<Todo> _list = new();
        public StaticData()
        {
            this.Add(new Todo(1, "Lernen"));
            this.Add(new Todo(2, "Fenster putzen"));
            this.Add(new Todo(3, "Hausübungen erledigen"));
            this.Add(new Todo(4, "Auto waschen"));
            this.Add(new Todo(5, "Küche aufräumen"));
            this.Add(new Todo(6, "Büroarbeit erledigen"));
        }

        public bool Add(Todo item)
        {
            _list.Add(item);
            return true;
        }

        public List<Todo> GetAll()
        {
            return _list;
        }
    }
}
