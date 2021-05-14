

using System;

namespace Model
{
   public class Component
   {
        public String Name { get; set; }
        public String Description { get; set; }

        public Component(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}