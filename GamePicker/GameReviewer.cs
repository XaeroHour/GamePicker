using System;
using System.Collections.Generic;
using System.Text;

namespace GamePicker
{
    public class GameReviewer
    {
        public string ReviewerName { get; set; }

        public List<GameRating> GameRatings { get; private set; }

        public GameReviewer(string name)
        {
            ReviewerName = name;
        }

        /// <summary>
        /// Get the rating for the given game
        /// </summary>
        /// <param name="gameName">The name of the game reviewed</param>
        /// <returns>Returns a GameRating, or null if no review was found</returns>
        public GameRating FindReviewFor(string gameName) => GameRatings.Find(game => game.RatedGame == gameName);

        /// <summary>
        /// Submit a review for a given game. Adds a new review or updates an existing one automatically.
        /// </summary>
        /// <param name="gameName">The name of the game to review</param>
        /// <param name="rating">The rating to give the game</param>
        public void SubmitReviewFor(string gameName, GameRating.RatingValue rating)
        {
            Game game = GameLibrary.FindGame(gameName);
            
            if (game == null)
            {
                throw new Exception($"Unable to find game named {gameName} in the library for review.");
            }

            SubmitReviewFor(game, rating);
        }

        /// <summary>
        /// Submit a review for a given game. Adds a new review or updates an existing one automatically.
        /// </summary>
        /// <param name="gameName">The game to review</param>
        /// <param name="rating">The rating to give the game</param>
        public void SubmitReviewFor(Game game, GameRating.RatingValue rating)
        {
            GameRating lookup = GameRatings.Find(g => g.RatedGame == game);
            
            if (lookup == null)
            {
                GameRatings.Add(new GameRating(game));
            }

            lookup.Rating = rating;
        }
    }
}
