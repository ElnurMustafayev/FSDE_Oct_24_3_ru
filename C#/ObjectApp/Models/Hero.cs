using ObjectApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectApp.Models;

class Hero
{
    public Weapon[] Weapons { get; set; }

    public Hero()
    {
        this.Weapons = [];
    }

    public void ThrowAllWeapons()
    {
        for (int i = 0; i < this.Weapons.Length; i++)
        {
            if (this.Weapons[i] is IThrowable)
            {
                IThrowable throwable = this.Weapons[i] as IThrowable;
                throwable.Throw();
            }
        }
    }

    public void UseWeapon(int index)
    {
        if(index > 0 && index < this.Weapons.Length)
        {
            this.Weapons[index].Use();
        }
    }
}
