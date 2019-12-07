﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_2019
{
    class Controller
    {
        Game game;
        View view;

        // Constructor
        public Controller( View view)
        {
            this.game = new Game();
            this.view = view;
        }

        /// <summary>
        /// This fonction launch the view update. It allows to vizualize the change of the party
        /// </summary>
        public void ViewUpdate()
        {
            view.Display(this.game);
        }

        /// <summary>
        /// This fonction initialize the view thanks to the information include in the game
        /// </summary>
        public void Initialisation()
        {
            view.Initialisation();
        }


        /// <summary>
        /// This fonction is "the main" fonction because it launch the game
        /// </summary>
        public void LaunchGame()
        {
            Initialisation();

            // Loop for the turns
            int tour = 0;
            while (tour != 20)
            {
                foreach (Player p in game.Player_list)
                {
                    TurnOfPlayer(p);
                }
                tour++;
            }
        }

        public void TurnOfPlayer(Player player)
        {
            int value = game.Board.ValueDice();
            int newposition=game.NewPosition(player, value);
            game.LaunchCaseMethode(newposition, player,game.Board);
        }

        




    }
}
