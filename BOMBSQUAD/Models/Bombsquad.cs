using System;
using System.Collections.Generic;

namespace BOMBSQUAD.Models
{
    public class Bombsquad
    {
        // HINT_RADIUS: distance from a clicked cell
        internal const int HINT_RADIUS = 3;
        // BOMB_DENSITY: average nomber of bombs per game
        internal const int BOMB_DENSITY = 3;
        internal const int HORIZONTAL_CELLS = 16;
        public const int VERTICAL_CELLS = 8;
        public const string BACK_COLOR = "skyblue";
        public const string ALT_BACK_COLOR = "steelblue";
        public const string COLOR = "black";
        public const string ALT_COLOR = "white";

        // properties and methods
        public int ArmedCells { get; private set; }
        public bool GameOver { get; internal set; }
        public Dictionary<string, Cell> Cells { get; private set; } = new Dictionary<string, Cell> { };
        internal Cell ClickedCell { get; set; }
        private int UnflaggedBombCount
        {
            get
            {
                int return_value = 0;
                foreach (Cell cell in Cells.Values)
                    if (cell.Armed && !cell.Flagged)
                    {
                        return_value++;
                    }
                return return_value;
            }
        }
        public int FlagCount
        {
            get
            {
                int value = 0;
                foreach (Cell cell in Cells.Values)
                    if (cell.Flagged && !cell.Armed)
                    {
                        value++;
                    }
                return value;
            }
        }
        public double Score
        {
            get
            {

            }
        }

        private void RefreshCells()
        {
            ArmedCells = 0;
            Cells = new Dictionary<string, Cell> { };
            for (int i = 0; i < VERTICAL_CELLS; i++)
            {
                for (int j = 0; j < HORIZONTAL_CELLS; j++)
                {
                    Cell cell = new Cell(i, j, this);
                    Cells.Add(cell.Address, cell);
                    if (cell.Armed)
                    {
                        ArmedCells++;
                    }
                }
            }

        }

        private void SetInitialHint()
        {
            Random rand = new Random();
            int rand_i = rand.Next(1, BombSquad.VERTICAL_CELLS);
            int rand_j = rand.Next(1, BombSquad.HORIZONTAL_CELLS);
            Cell initial_cell = Cells["R" + rand_i + "C" + rand_j];
            if (!initial_cell.Armed)
            {
                initial_cell.Clicked = true;
            }
            else
                foreach (Cell cell in initial_cell.AdjacentCells)
                {
                    if (!cell.Armed)
                    {
                        cell.Clicked = true;
                        break;
                    }
                }
        }

        public void Reset()
        {
            GameOver = false;
            RefreshCells();
            SetInitialHint();
        }

        public void ClickCell(string click_cell)
        {
            if (Cell.ContainsKey(click_cell))
            {
                ClickedCell = Cells[click_cell];
                ClickCell.Click();
            }

        }

        public void FlagCell(string flag_cell)
        {
            if (Cell.ContainsKey(flag_cell))
            {
                ClickedCell = Cells[flag_cell];
                FlagCell.ToggleFlag();
            }
            if (UnflaggedBombCount = 0)
            {
                GameOver = true;
            }
        }
    }
}
