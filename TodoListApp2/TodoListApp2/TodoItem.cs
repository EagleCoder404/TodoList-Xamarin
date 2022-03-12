﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListApp2
{
    class TodoItem
    {
        public string TodoText { get; set; }
        public bool Complete { get; set; }

        public TodoItem(string TodoText, bool Complete)
        {
            this.TodoText = TodoText;
            this.Complete = Complete;
        }
    }
}