using System;
namespace RPG_Dio.src.Entities
{
    public class Engine
    {
        public Engine(){

        }
        public int RandValue(int DiceFaces){
            Random RandValue = new Random();
            int Value = RandValue.Next(1,DiceFaces);
            return Value;
        }

    }
}
