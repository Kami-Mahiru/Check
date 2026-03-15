//该文件的用途是列举角色所应有的“细化后的属性”

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_Game.Game_Universal_Settings
{
    internal class Game_Character
    {
        public string Character_Categories ;
        public string Character_Categories_Word
        {
            get
            {
                return Character_Categories ;
            }
            set
            {
                Character_Categories = value ;
            }
        }

        //用于标定生物的类型以判定的属性数值合理性

        private Character_Attribute Hit;
        public Character_Attribute Hit_Check
        {
            get
            {
                return Hit;
            }
            set
            {
                Hit = value;
            }
        }

        //用于检定攻击是否生效的属性

        private Character_Attribute Dodge;
        public Character_Attribute Dodge_Check
        {
            get
            {
                return Dodge;
            }
            set
            {
                Dodge = value;
            }
        }

        //用于检定闪避是否生效的属性

        private Character_Attribute ATK;
        public Character_Attribute ATK_Cal
        {
            get
            {
                return ATK;
            }
            set
            {
                ATK = value;
            }
        }

        //用于计算伤害的属性

        private Character_Attribute DEF;
        public Character_Attribute DEF_Cal
        {
            get
            {
                return DEF;
            }
            set
            {
                DEF = value;
            }
        }

        //用于计算伤害减免的属性

    }
}
