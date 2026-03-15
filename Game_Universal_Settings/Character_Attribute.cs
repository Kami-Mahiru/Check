//该文件的用途是细化角色属性

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_Game.Game_Universal_Settings 
{
    internal class Character_Attribute
    {
        private string Att_Cla;
        public string Attribute_Class
        {
            get
            {
                return Att_Cla;
            }
            set
            {
                Att_Cla = value;
            }
        }

        //用于区分角色属性的用途

        private int Att_Val;
        public int Attribute_Value
        {
            get
            {
                return Att_Val;
            }
            set
            {
                Att_Val = value;
            }
        }

        //用于存储角色属性的数值

    }
}
