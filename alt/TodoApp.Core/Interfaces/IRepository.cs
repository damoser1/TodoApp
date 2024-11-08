using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Models;

namespace TodoApp.Core.Interfaces
{
    /// <summary>
    /// An interface for the todo app services
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Get all todos
        /// </summary>
        /// <returns>a list fo todo itmes</returns>
        List<Todo> GetAll();

        /// <summary>
        /// add a todo
        /// </summary>
        /// <param name="item">the todo to add</param>
        /// <returns>true if succesfully added</returns>
        bool Add(Todo item);
    }
}
