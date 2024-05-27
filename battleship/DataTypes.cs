using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{

    struct msg
    {
        public string type;
        public POS move;
        public string body;
        public string name;
    }

    
    struct Fleet
    {
        public POS[] Carrier;
        public POS[] Battleship;
        public POS[] Cruiser;
        public bool CarrierSunk;
        public bool BattleshipSunk;
        public bool CruiserSunk;                     
        

        public Fleet(POS[] car, POS[] bat, POS[] cru)
        {
            Carrier = car;
            Battleship = bat;
            Cruiser = cru;
            CarrierSunk = false;
            BattleshipSunk = false;
            CruiserSunk = false;    
        }
    }

    struct POS
    {
        public int X;
        public int Y;
        public bool Hit;

        public POS(int x, int y)
        {
            X = x;
            Y = y;
            Hit = false;
        }
    }

    
}
