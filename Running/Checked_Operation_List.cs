using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Fighting_Game.Game_Universal_Settings;



namespace Fighting_Game.Running
{
    internal class Checked_Operation_List
    {
        public List<int> Operation_Judge(Game_Character Check_Obj_1, Game_Character Check_Obj_2, string Judged_Operation)
        {
            int Checked_Prj_1_Nomber = 0;
            int Checked_Prj_2_Nomber = 0;
            List<int> O_J_Result = new List<int>();

            //行为确定初始化

            if (Judged_Operation == "Attack")
            {
                Checked_Prj_1_Nomber = Check_Obj_1.Hit_Check.Attribute_Value;
                Checked_Prj_2_Nomber = Check_Obj_2.Dodge_Check.Attribute_Value;
            }
            else if ( Judged_Operation == "Counterattack" )
            {
                Checked_Prj_1_Nomber = Check_Obj_1.Dodge_Check.Attribute_Value;
                Checked_Prj_2_Nomber = Check_Obj_2.Hit_Check.Attribute_Value;
            }

            //确定调取的行为属性

            O_J_Result[0] = Checked_Prj_1_Nomber;
            O_J_Result[1] = Checked_Prj_2_Nomber;

            //行为属性合并返回准备

            return O_J_Result;
        }

        //对抗行为属性调用判定
    }
}
