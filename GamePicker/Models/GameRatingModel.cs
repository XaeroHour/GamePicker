using System;
using System.Collections.Generic;
using System.Text;

namespace GamePicker
{
    public class GameRatingModel
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

        public int Id { get; set; } = 0;

        /// <summary>
        /// The rating given to the game
        /// </summary>
        public RatingValue Rating { get; set; } = RatingValue.NeverHeardOfIt;

        /// <summary>
        /// The game being rated
        /// </summary>
        public int GameId { get; set; }

        public int ReviewerId { get; set; }

        public GameRatingModel(GameModel game = null, int reviewerId = 0, RatingValue rating = RatingValue.NeverHeardOfIt) : this(game?.Id ?? 0, reviewerId, rating)
        { }

        public GameRatingModel(int gameId = 0, int reviewerId = 0, RatingValue rating = RatingValue.NeverHeardOfIt)
        {
            GameId = gameId;
            ReviewerId = reviewerId;
            Rating = rating;
        }
    }
}
