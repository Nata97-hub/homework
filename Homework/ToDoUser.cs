using System;
using System.Collections.Generic;
using System.Text;


//namespace Homework 5/2.


namespace Homework
{
    class ToDoUser
    {
        public Guid UserId { get; set; }
        public string TelegramUserName { get; set; }
        public DateTime RegisteredAt { get; set; }
        


        public string telegramUserName;
        public ToDoUser(string telegramUserName)
        {
            this.telegramUserName = telegramUserName;
        }



        ToDoUser UserId = Guid.NewGuid();
        ToDoUser RegisteredAt = DateTime.UtcNow;
    }
}
