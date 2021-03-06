﻿using System.Collections.Generic;
using System.Linq;
using TodoSQL.Entities;
using TodoSQL.Models;

namespace TodoSQL.Repositories
{
    public class TodoRepository
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public void Add(Todo todo, User user)
        {
            var addTodoWithUser = new Todo
            {
                Title = todo.Title,
                Content = todo.Content,
                DateTime = todo.DateTime,
                Description = todo.Description,
                IsDone = todo.IsDone,
                IsUrgent = todo.IsUrgent,
                TodoId = todo.TodoId,
                User = user
            };

            todoContext.Todos.Add(addTodoWithUser);
            todoContext.SaveChanges();
        }

        public List<Todo> GetAll()
        {
            return todoContext.Todos.ToList();
        }

        public void Delete(long id)
        {
            Todo todo = todoContext.Todos.FirstOrDefault(x => x.TodoId == id);
            todoContext.Todos.Remove(todo);
            todoContext.SaveChanges();
        }

        public Todo GetEditView(long id)
        {
            return todoContext.Todos.FirstOrDefault(x => x.TodoId == id);
        }

        public void Edit(Todo todo, long id)
        {
            todoContext.Todos.Update(todo);
            todoContext.SaveChanges();
        }
    }
}
