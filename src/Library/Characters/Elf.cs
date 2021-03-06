using System;
using System.Collections.Generic;

namespace RolePlay
{
    public class Elf
    {
        private string name;

        private int health;

        private int damage;

        private List<dynamic> elements = new List<dynamic>();

        public Elf(string name, int health, int damage)
        {

            this.Name = name;
            this.Damage = damage;
            this.Health = health;

        }


        public string Name
        {
            get
            {
                return name;
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
                return health;
            }
            set
            {
                this.health = value;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public int TotalDamage(){
             int total = this.Damage;
             foreach (dynamic item in elements)
             {
                total += item.Damage;
             }
            
            return total;
        }
        public int TotalDefense(){
             
             int total = this.Health;
             foreach (dynamic item in elements)
             {
                total += item.Health;
             }
            return total;
        }

        public void AddElement(dynamic element)
        {
            elements.Add(element);
        }

        public void RemoveElement(dynamic element)
        {
            elements.Remove(element);
        }





    }
}