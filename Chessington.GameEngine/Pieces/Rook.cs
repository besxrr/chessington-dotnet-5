using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var squares = new List<Square>();
            var locationOfPiece = board.FindPiece(this);


            if (!board.OutOfBounds(Square.At(locationOfPiece.Row, locationOfPiece.Col + 1)))
            {
                for (var i = locationOfPiece.Col+1; i < 8; i++)
                {
                    var targetSquare = Square.At(locationOfPiece.Row, i);
                    var targetSquareOnBoard = board.GetPiece(targetSquare);
                    if (targetSquareOnBoard == null)
                    {
                        squares.Add(targetSquare);
                    }
                    else
                    {
                        if (!targetSquareOnBoard.Player.Equals(currentPlayerColour))
                        {
                            squares.Add(targetSquare);
                        }
                        break;
                    }
                }
            }

            if (!board.OutOfBounds(Square.At(locationOfPiece.Row, locationOfPiece.Col - 1)))
            {
                for (var i = locationOfPiece.Col-1; i < 8; i--)
                {
                    var targetSquare = Square.At(locationOfPiece.Row, i);
                    var targetSquareOnBoard = board.GetPiece(targetSquare);
                    if (targetSquareOnBoard == null)
                    {
                        squares.Add(targetSquare);
                    }
                    else
                    {
                        if (!targetSquareOnBoard.Player.Equals(currentPlayerColour))
                        {
                            squares.Add(targetSquare);
                        }
                        break;
                    }
                }  
            }

            if (!board.OutOfBounds(Square.At(locationOfPiece.Row + 1, locationOfPiece.Col)))
            {
                for (var i = locationOfPiece.Row + 1; i < 8; i++)
                {
                    var targetSquare = Square.At(i, locationOfPiece.Col);
                    var targetSquareOnBoard = board.GetPiece(targetSquare);
                    if (targetSquareOnBoard == null)
                    {
                        squares.Add(targetSquare);
                    }
                    else
                    {
                        if (!targetSquareOnBoard.Player.Equals(currentPlayerColour))
                        {
                            squares.Add(targetSquare);
                        }
                        break;
                    }
                }
            }

            if (!board.OutOfBounds(Square.At(locationOfPiece.Row - 1, locationOfPiece.Col)))
            {
                for (var i = locationOfPiece.Row - 1; i < 8; i--)
                {
                    var targetSquare = Square.At(i, locationOfPiece.Col);
                    var targetSquareOnBoard = board.GetPiece(targetSquare);
                    if (targetSquareOnBoard == null)
                    {
                        squares.Add(targetSquare);
                    }
                    else
                    {
                        if (!targetSquareOnBoard.Player.Equals(currentPlayerColour))
                        {
                            squares.Add(targetSquare);
                        }
                        break;
                    }
                } 
            }
            return squares;
        }
    }
}