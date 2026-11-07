using System;
using System.Collections.Generic;
using System.Text;


//namespace Homework 5/2.


namespace Homework
{
    class ToDoItem
    {
        public enum ToDoItemState
        {
            Active,
            Completed
        }


        public Guid Id { get; set; }
        public ToDoUser User { get; set; }
        public string Name { get; set; }
        public DateTime RegisteredAt { get; set; }
        public ToDoItemState State { get; set; }
        public DateTime? StateChangedAt { get; set; }
        public string user;
        public string name;



        public ToDoItem (string user, string name)
        {
            this.user = user;
            this.name = name;
        }



        ToDoItem Id = Guid.NewGuid();
        ToDoItem CreatedAt = DateTime.UtcNow;
        ToDoItem State = ToDoItemState.Active;
    }
}
