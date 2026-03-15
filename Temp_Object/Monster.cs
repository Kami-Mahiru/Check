using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Fighting_Game.Game_Universal_Settings;



namespace Fighting_Game.Temp_Object
{
    internal class Monster
    {
        public Monster()
        {
            Game_Character Monster_Beast = new Game_Character();

            //生成“怪物”角色

            Monster_Beast.Character_Categories = "Beast";
            Random Beast_Value_Formation = new Random();
            Monster_Beast.Hit_Check.Attribute_Value = Beast_Value_Formation.Next(1,81);
            Monster_Beast.Dodge_Check.Attribute_Value = Beast_Value_Formation.Next(1,31);
            Monster_Beast.ATK_Cal.Attribute_Value = Beast_Value_Formation.Next(1, 20);
            Monster_Beast.DEF_Cal.Attribute_Value = Beast_Value_Formation.Next(1, 20);

            //生成“怪物”角色的数值
        }
    }
}
