using System;
using System.Collections.Generic;
using System.Text;

namespace gunGame
{
    class Player
    {
        //Variables for parameters of player
        string _name;
        int _health;
        int _xp;
        Item[] _inventory;

        //Attributes of player

        //Functions of player (ie attack, damage, etc...)

        //Init player spawns the player with certain parameters
        public void initPlayer(string name, int health, int xp, Item[] inventory)
        {
            this._name = name;
            this._health = health;
            this._xp = xp;
            this._inventory = inventory;
        }
    }
}