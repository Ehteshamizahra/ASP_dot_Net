﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack_game
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public string Name { get; set; }
        public int balance { get; set; }
        public bool isActivelyPlaying { get; set; }

        //overloaded operators
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator-(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}