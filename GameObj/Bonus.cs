using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOMBERMAN.GameObj
{
    class Bonus:GameObjets
    {

         public enum Bonustype
        {
            ARMOR,
            SPEED,
            D_SPEED,
            DISAMORCE,
            LIFE,
            EFFECT,
            D_EFFET,
            KICK,
            LAUNCH
        }

        private Bonustype bonusTtype;

        internal Bonustype BonusTtype { get => bonusTtype; set => bonusTtype = value; }

        public Bonus(int[] casePos,int fheight,int fWidth,int nbFrame,Bonustype btype)
            :base(casePos,fheight,fWidth,nbFrame)
        {
            bonusTtype = btype;
        }
    }
}
