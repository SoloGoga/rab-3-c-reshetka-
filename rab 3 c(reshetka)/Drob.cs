using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rab_3_c_reshetka_
{
    class Drob
    {
        public int chis, znam;

        public Drob(int chis, int znam)
        {
            this.chis = chis;

            this.znam = znam;
        }

        public static Drob operator +(Drob d1, Drob d2) // метод сложения
        {
            if (d1.znam == d2.znam)
            {
                return new Drob(d1.chis + d2.chis, d1.znam);
            }
            else {
                return new Drob(d1.chis * d2.znam + d2.chis * d1.znam, d1.znam * d2.znam);
            }
        }

        public static Drob operator -(Drob d1, Drob d2) // метод вычитания
        {
            if (d1.znam == d2.znam)
            {
                return new Drob(d1.chis - d2.chis, d1.znam);
            }
            else
            {
                return new Drob(d1.chis * d2.znam - d2.chis * d1.znam, d1.znam * d2.znam);
            }
        }

        public static Drob operator *(Drob d1, Drob d2) // метод умножения 
        {
            return new Drob(d1.chis * d2.chis, d1.znam * d2.znam);
        }

        public static Drob operator /(int num, Drob d1) // деление дробей ,при делении 1 на дробь выдает обратную дробь
        {
            return new Drob(d1.znam * num, d1.chis);
        }

        public static string Vivod(Drob Viv)
        {
            return Viv.chis + "\r\n" + "---" + "\r\n" + Viv.znam;
        }
    }
}
