using System;

namespace RolePlay
{
    public class Dwarf
    {
        private string name;

        private int health;
        
        public Dwarf(string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            
            set
            {
                this.health = value;
            }
        }

     
    }
}