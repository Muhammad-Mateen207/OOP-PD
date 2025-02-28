using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_04_Task3_
{
    internal class Player
    {
        public float HP;
        public int maxHP;
        public int energy;
        public int maxenergy;
        public float armor;
        public string name;
        public Stats skillstats;

        public Player(string name, float HP, int energy, int armor)
        {
            this.name = name;
            this.HP = HP;
            this.energy = energy;
            this.armor = armor;
        }

        public string attack(Player p1)
        {
            string output = "";
            if (skillstats.cost > energy)
            {
                output = name + " attempted to use " + skillstats.name + ", but didn't have enough energy!";
            }
            else
            {
                float effectiveval = p1.armor - skillstats.penetration;
                float damage = skillstats.damage * ((100 - effectiveval) / 100);
                energy = energy - skillstats.cost;
                output = name + " used skill " + skillstats.name + ", " + skillstats.description + ", against " + p1.name + ", doing " + damage + " damage!";
                if (skillstats.heal != 0)
                {
                    output += "\n" + name + " healed for " + skillstats.heal + " health";
                }
                if (p1.HP - damage <= 0)
                {
                    output += "\n" + p1.name + " died!";
                }
                else if (p1.HP - damage > 0)
                {
                    p1.HP = p1.HP - damage;
                    output += "\n" + p1.name + " is at " + p1.HP + "% health";
                }
            }
            return output;
        }

        public void learnSkill(Stats ss)
        {
            skillstats = ss;
        }

        public void updatehealth(int hp)
        {
            HP = hp;
        }

        public void updatearmor(int a)
        {
            armor = a;
        }

        public void updateenergy(int e)
        {
            energy = e;
        }

        public void updatename(string n)
        {
            name = n;
        }

    }
}
