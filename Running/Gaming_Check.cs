//游戏检定文件

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Fighting_Game.Game_Universal_Settings;



namespace Fighting_Game.Running
{
    internal class Gaming_Check
    {
        static string Confront_Check(Game_Character Check_Object_1, Game_Character Check_Object_2, string Checked_Project)
        {
            string C_C_Result = "";
            int Checked_Project_1_Nomber = 0;
            int Checked_Project_2_Nomber = 0;
            Checked_Operation_List C_O_L = new Checked_Operation_List();
            Checked_Project_1_Nomber = C_O_L.Operation_Judge(Check_Object_1, Check_Object_2, Checked_Project)[0];
            Checked_Project_2_Nomber = C_O_L.Operation_Judge(Check_Object_1, Check_Object_2, Checked_Project)[1];
            int C_O_1_Result = Single_Check(Check_Object_1, Checked_Project_1_Nomber);
            int C_O_2_Result = Single_Check(Check_Object_2, Checked_Project_2_Nomber);
            if (C_O_1_Result > C_O_2_Result)
            {
                C_C_Result = "Success";
            }
            else
            {
                C_C_Result = "Defeat";
            }
            return C_C_Result;
        }

        //对抗检定

        static int Single_Check(Game_Character Check_Object, int Checked_Project_Nomber)
        {
            int S_C_Result = 0;
            Random Check_Nomber_Generate = new Random();
            int S_C_G_Result = Check_Nomber_Generate.Next(1, 101);
            if (S_C_G_Result == 0)
            {
                S_C_Result = 0;
            }
            else if (S_C_G_Result > Checked_Project_Nomber)
            {
                S_C_Result = 1;
            }
            else if (Math.Floor(Checked_Project_Nomber * 0.05) < S_C_G_Result && S_C_G_Result < Checked_Project_Nomber)
            {
                S_C_Result = 3;
            }
            else if (0 < S_C_G_Result && S_C_G_Result < Math.Floor(Checked_Project_Nomber * 0.05))
            {
                S_C_Result = 4;
            }
            return S_C_Result;
        }

        //单人检定
        //结果对应如下：0——大失败；1——失败；2——困难成功；3——成功；4——大成功

    }
}
