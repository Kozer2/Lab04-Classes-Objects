using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace Lab04Tests
{
    public class UnitTest1
    {

        // test if winners works 
        [Fact]
        public void Game_board_test_if_winner_works()
        {
            // arrange
            Board board = new Board();

            // act
            board.GameBoard[0, 0] = "x";
            board.GameBoard[0, 1] = "x";
            board.GameBoard[0, 2] = "x";

            // assert
            Assert.True(Game.CheckForWinner(board));
        }

        // test if no winners works
        [Fact]
        public void Game_board_test_if__no_winner_works()
        {
            // arrange
            Board board = new Board();

            // act

            // assert
            Assert.False(Game.CheckForWinner(board));
        }


        // test if game switches players
        [Fact]
        public void Game_Switch_Players_Works()
        {
            // arrange
            Game game = new Game(new Player(), new Player());

            // act
            game.SwitchPlayer();
            game.SwitchPlayer();


            // assert
            Assert.True(game.PlayerTwo.IsTurn);

        }


        // test if game tracks the position on the board
        [Fact]
        public void Game_tracks_player_position()
        {
            // arrange


            // act

            // assert

        }

    }
}
