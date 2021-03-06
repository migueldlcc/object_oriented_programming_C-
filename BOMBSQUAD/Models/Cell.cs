using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOMBSQUAD.Models
{
    public class Cell
    {
        private readonly Bombsquad game;
        internal readonly bool Armed;
        public readonly int XCoordinate;
        public readonly int YCoordinate;
        private bool Exploded { get; set; }
        internal bool Flagged { get; private set; }
        public bool Clicked { get; set; }
        public string Address
        {
            get
            {
                return "R" + YCoordinate + "C" + XCoordinate;
            }
        }
    }
    public string Content
    {
        get
        {
            if (Exploded == true)
            {
                return "&#128165;";
            }
            else if (Flagged == true)
            {
                return "&#128681;";
            }
            else if (Armed == true)
            {
                return "";
            }
            else if (Clicked == true)
            {
                return AdjacentBombCount.ToString();
            }
            return "";
        }
    }
    internal List<Cell> AdjacentCells
    {
        get
        {
            List<Cell> output = new List<Cell> { };
            for (int row = YCoordinate - 1; YCoordinate + 1 >= row; row++)
            {
                for (int col = XCoordinate - 1; XCoordinate + 1 >= col; col++)
                {
                    string address = "R" + row + "C" + col;
                    if (game.Cells.ContainsKey(address) && address != Address)
                    {
                        Cell adj = game.Cells[address];
                        AdjacentCells.Add(adj);
                    }
                }
            }
            return output;
        }
    }
    private int AjacentBombCount
    {
        get
        {

            int output = 0;
            foreach (Cell cell in game.AdjacentCells)
            {
                if (cell.Armed == true)
                {
                    output++;
                }
            }
            return output;
        }
    }
    
    internal Cell(int row, int col, int Bombsquad bombsquad)
    {
        row = YCoordinate;
        col = XCoordinate;
        bombsquad = game;

        Random rand = new Random();
        int rand_i = rand.Next(0, game.Cells.Count);
        int rand_j = rand_i % Bombsquad.BOMB_DENSITY;
        if (rand_j == 0)
        {
            Armed = true;
        }

    }
    internal void ToggleFlag()
    {
        if (Exploded = false && Flagged = false && Clicked = false && game.FlagCount < game.ArmedCells)
        {
            Flagged = true;
        }
        else
        {
            Flagged = false;
        }
    }
    private void Explode()
    {
        game.GameOver = true;
        if (Flagged = false)
        {
            Exploded = true;
        }
        foreach (Cell cell in game.Cells.Values)
        {
            if (cell.Armed && cell.Exploded == false && cell.Flagged == false)
            {
                cell.Explode();
            }
        }

    }
    internal void Click()
    {
        if (Flagged = false || this == game.ClickedCell)
        {
            Clicked = true;
            Flagged = true;
            if (Armed && !Exploded)
            {
                Explode();
            }
            foreach (Cell cell in AdjacentCells)
            {
                if (!cell.Armed && cell.XCoordinate < game.ClickedCell.XCoordinate + Bombsquad.HINT_RADIUS
                    && cell.XCoordinate > game.ClickedCell.XCoordinate - Bombsquad.HINT_RADIUS
                    && cell.YCoordinate > game.ClickedCell.YCoordinate + Bombsquad.HINT_RADIUS
                    && cell.YCoordinate > game.ClickedCell.YCoordinate - Bombsquad.HINT_RADIUS)
                {
                    Click();
                }
            }
        }
    }
}   
