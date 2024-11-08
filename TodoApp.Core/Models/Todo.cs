using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.Models
{
    public class Todo
    {
        public int Id { get; set; } = 0;

        public string Title { get; set; }

        public Todo(string title)
        {
            Title = title;
        }

        public Todo(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
