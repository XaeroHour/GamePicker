using System;
using System.Collections.Generic;
using System.Text;

namespace GamePicker
{
    public class GameRating
    {
        /// <summary>
        /// Enum for how a reviewer can feel about a game
        /// </summary>
        public enum RatingValue
        {
            NeverHeardOfIt,
            Bleh,
            Meh,
            Cool,
            LoveIt,
        }

        /// <summary>
        /// The rating given to the game
        /// </summary>
        public RatingValue Rating { get; set; }

        /// <summary>
        /// The game being rated
        /// </summary>
        public Game RatedGame { get; private set; }

        public GameRating(Game game = null, RatingValue rating = RatingValue.NeverHeardOfIt)
        {
            RatedGame = game;
            Rating = rating;
        }
    }
}
