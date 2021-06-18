

using System;

namespace Model
{
   public class Component
   {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public Component(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}