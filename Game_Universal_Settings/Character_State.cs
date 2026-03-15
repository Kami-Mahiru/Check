using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_Game.Game_Universal_Settings
{
    internal class Character_State
    {
        int HP;
        int HP_Cal
        {
            get
            {
                return HP;
            }
            set
            {
                HP = value;
            }
        }

        //生命值

        int MP;
        int MP_Cal
        {
            get
            {
                return MP;
            }
            set
            {
                MP = value;
            }
        }

        //魔法值

        int EXP;
        int EXP_Cal
        {
            get
            {
                return EXP;
            }
            set
            {
                EXP = value;
            }
        }
    }
}
