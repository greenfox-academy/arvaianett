﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODO.Context;
using TODO.Models;

namespace TODO.Repositories
{
    public class TodoRepository
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public void Add(Todo todo)
        {
            todoContext.Todos.Add(todo);
        }

        public List<Todo> GetAll()
        {
            return todoContext.Todos.ToList();
        }
    }
}
