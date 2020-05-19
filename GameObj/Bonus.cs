using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOMBERMAN.GameObj
{
    [Serializable]
    public class Bonus:GameObjets
    {

         public enum Bonustype
        {
            BOMBE,
            SPEED,
            D_SPEED,
            DISAMORCE,
            LIFE,
            EFFECT,
            D_EFFET,
            KICK,
            LAUNCH,
            NONE
        }

        private Bonustype bonusTtype;

        internal Bonustype BonusTtype { get => bonusTtype; set => bonusTtype = value; }

        public Bonus(int[] casePos,int fheight,int fWidth,int nbFrame,Bonustype btype)
            :base(casePos,fWidth,fheight,nbFrame)
        {
            int x, y;
            x = (60 - fWidth) / 2;
            y = (60 - fheight) / 2;
            bonusTtype = btype;
        }
    }
}
