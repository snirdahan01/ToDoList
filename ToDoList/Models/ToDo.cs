using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; } //Each ToDo has a uniq Id.
        public string Description { get; set; } //Description of the ToDo.
        public bool IsDone { get; set; } //Tells me if the ToDo is done.
        public virtual ApplicationUser User { get; set; } //A constructor to build a User.
    }
}