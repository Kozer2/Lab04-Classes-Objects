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
            board.GameBoard[0, 0] = "x";
            board.GameBoard[0, 1] = "x";
            board.GameBoard[0, 2] = "x";

            // act
            bool result = Game.CheckForWinner(board);

            // assert
            Assert.True(result);
        }

        // test if no winners works
        [Fact]
        public void Game_board_test_if_no_winner_works()
        {
            // arrange
            Board board = new Board();

            // act
            bool result = Game.CheckForWinner(board);
            // assert
            Assert.False(result);
        }


        // test if game switches players
        [Fact]
        public void Game_Switch_Players_Works()
        {
            // arrange
            Game game = new Game(new Player(), new Player());

            // act
            game.SwitchPlayer(); // use twice as it starts with player 1 then goes to player 2
            game.SwitchPlayer();


            // assert
            Assert.True(game.PlayerTwo.IsTurn);

        }


        // test if game tracks the position on the board with invalid input 
        [Theory]
        [InlineData(11)]
        [InlineData(10)]
        [InlineData(30)]
        public void Game_tracks_player_position_null_return(int position)
        {
            // arrange
            /*Board board = new Board();
            Game game = new Game(new Player(), new Player());
            int position = 2;*/



            // act
            /*game.SwitchPlayer();
            var result = Player.PositionForNumber(position);
            string mark = "x";*/

            Position result = Player.PositionForNumber(position);
            // assert


            Assert.Null(result);

        }


        // test if game tracks the position on the board
        [Theory]
        [InlineData(1, 0,0)]
        [InlineData(2, 0,1)]
        [InlineData(3, 0,2)]
        public void Game_tracks_player_position(int position, int expectedRow, int expectedColumn)
        {
            // arrange
            // from input



            // act
            Position result = Player.PositionForNumber(position);

            // assert

            Assert.Equal(expectedRow, result.Row);
            Assert.Equal(expectedColumn, result.Column);

           

        }

    }
}
