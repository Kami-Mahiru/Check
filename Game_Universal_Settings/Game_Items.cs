//该文件的作用是列举武器的属性

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting_Game.Game_Universal_Settings 
{
    internal class Game_Items_Attribute
    {
        private string Categories;
        public string Item_Categorise
        {
            get
            {
                return Categories;
            }
            set
            {
                Categories = value;
            }
        }

        //道具类型

        private List<string> Improved_Attribute;
        public List<string> Item_Improve_Attribute
        {
            get
            {
                return Improved_Attribute;
            }
            set
            {
                Improved_Attribute = value;
            }
        }

        //道具加成对象

        private List<int> Improve_Value;
        public List<int> Item_Improve_Value
        {
            get
            {
                return Improve_Value;
            }
            set
            {
                Improve_Value = value;
            }
        }

        //道具加成数值
    }
}