﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{

    // Struct for messages that are sent over network
    struct msg
    {
        public string type;
        public Coord move;
        public string body;
        public string name;
    }

    // Struct for holding the players ships
    struct Fleet
    {
        public Coord[] Carrier;
        public Coord[] Battleship;
        public Coord[] Cruiser;
        public bool CarrierSunk;
        public bool BattleshipSunk;
        public bool CruiserSunk;
        

        public Fleet(Coord[] car, Coord[] bat, Coord[] cru, Coord[] sub, Coord[] des)
        {
            Carrier = car;
            Battleship = bat;
            Cruiser = cru;
            CarrierSunk = false;
            BattleshipSunk = false;
            CruiserSunk = false;
            
        }

        

    }

    struct Coord
    {
        public int X;
        public int Y;
        public bool Hit;

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
            Hit = false;
        }
    }

    
}
