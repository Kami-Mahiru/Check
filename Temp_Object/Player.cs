using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Fighting_Game.Game_Universal_Settings;



namespace Fighting_Game.Temp_Object
{
    internal class Player
    {
        public void Player_Formation()
        {
            Game_Character Player = new Game_Character();

            //生成玩家角色

            Player.Character_Categories = "human";
            Player.Hit_Check.Attribute_Value = int.Parse(Console.ReadLine());
            Player.Dodge_Check.Attribute_Value = int.Parse(Console.ReadLine());
            Player.ATK_Cal.Attribute_Value = int.Parse(Console.ReadLine());
            Player.DEF_Cal.Attribute_Value = int.Parse(Console.ReadLine());

            //玩家自定义自己的游戏角色数值
        }
    }
}
