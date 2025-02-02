﻿using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public abstract class Piece
    {
        protected Piece(Player player)
        {
            Player = player;
            currentPlayerColour = Player.Equals(Player.White) ? Player.White : Player.Black;
        }

        public Player Player { get; private set; }
        public bool hasMoved { get; set; }

        public Player currentPlayerColour { get; private set; }

        public abstract IEnumerable<Square> GetAvailableMoves(Board board);

        public void MoveTo(Board board, Square newSquare)
        {
            var currentSquare = board.FindPiece(this);
            board.MovePiece(currentSquare, newSquare);
            hasMoved = true;
        }
        
    }
}