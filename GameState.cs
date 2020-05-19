using BOMBERMAN.GameWorlds;
using BOMBERMAN.GameObj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMBERMAN.GameWorlds
{
    [Serializable]
   public class GameState
    {
        public Player p1;
        public Player p2;
        public Tile[,] timap;
        public List<Bombe> BombeIngame;

        public GameState(Player p1, Player p2, Tile[,] tilmap)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.timap = tilmap;
        }
    }
}
