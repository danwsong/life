using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Life
{
    public partial class Life : Form
    {
        private bool[,] state;
        private Bitmap bitmap;
        private Graphics graphics;
        private bool playing;
        private bool currentBrush;
        private bool drawing;
        public static int speed;
        public static System.Timers.Timer timer;
        public static int stepSize;

        private const int TileSize = 8;
        private const int BorderWidth = 1;
        private const int BoardWidth = 128;
        private const int BoardHeight = 72;

        public Life()
        {
            InitializeComponent();

            // Set the sizes of the simulation viewport and the size of the form
            gameScreen.Size = new Size(BoardWidth * TileSize, BoardHeight * TileSize);
            ClientSize = new Size(BoardWidth * TileSize, gameScreen.Height + 40 + playButton.Height);

            // Set the location of the buttons
            playButton.Location = new Point(ClientSize.Width / 2 - playButton.Width - 10, gameScreen.Size.Height + 20);
            stepButton.Location = new Point(ClientSize.Width / 2 + 10, gameScreen.Size.Height + 20);
            settingsButton.Location = new Point(ClientSize.Width - settingsButton.Width - 20, gameScreen.Size.Height + 20);
            randomButton.Location = new Point(20, gameScreen.Size.Height + 20);
            clearButton.Location = new Point(40 + randomButton.Width, gameScreen.Size.Height + 20);

            // Create a graphics instance for the simulation viewport
            bitmap = new Bitmap(BoardWidth * TileSize, BoardHeight * TileSize);
            graphics = Graphics.FromImage(bitmap);

            // Generate a random state for the board, false value means a dead cell, true value means an alive cell
            Random rng = new Random();
            state = new bool[BoardWidth * 2, BoardHeight * 2];
            for (int y = BoardHeight / 2; y < BoardHeight * 3 / 2; y++)
            {
                for (int x = BoardWidth / 2; x < BoardWidth * 3 / 2; x++)
                {
                    state[x, y] = rng.Next(0, 2) == 0;
                }
            }

            // Default values for simulation speed and step size variables
            speed = 30;
            stepSize = 1;

            // Start the timer for the simualation
            timer = new System.Timers.Timer(1000.0 / speed);
            timer.Elapsed += HandleTimer;
            timer.Start();
        }

        // Returns the number of living neighbours of the cell at position (x, y) on the grid
        private int GetNeighbours(int x, int y)
        {
            // Number of living neighbours
            int neighbours = 0;

            // Check if each of the neighbours is alive
            // To the left
            if (x - 1 >= 0 && state[x - 1, y])
            {
                neighbours++;
            }
            // To the right
            if (x + 1 < BoardWidth * 2 && state[x + 1, y])
            {
                neighbours++;
            }
            // Up
            if (y - 1 >= 0 && state[x, y - 1])
            {
                neighbours++;
            }
            // Down
            if (y + 1 < BoardHeight * 2 && state[x, y + 1])
            {
                neighbours++;
            }
            // Upper left
            if (x - 1 >= 0 && y - 1 >= 0 && state[x - 1, y - 1])
            {
                neighbours++;
            }
            // Upper right
            if (x + 1 < BoardWidth * 2 && y - 1 >= 0 && state[x + 1, y - 1])
            {
                neighbours++;
            }
            // Bottom left
            if (x - 1 >= 0 && y + 1 < BoardHeight * 2 && state[x - 1, y + 1])
            {
                neighbours++;
            }
            // Bottom right
            if (x + 1 < BoardWidth * 2 && y + 1 < BoardHeight * 2 && state[x + 1, y + 1])
            {
                neighbours++;
            }

            // Return the number of living neighbours
            return neighbours;
        }

        // Handler function called each time the timer fires
        private void HandleTimer(object source, ElapsedEventArgs e)
        {
            // Call the redraw screen function only if the simulation is running
            if (playing)
                RedrawScreen();
        }

        // Updates the grid to the next generation based on the rules of the Game of Life and invalidates the viewport, with an optional argument for the number of generations to skip
        private void RedrawScreen(int steps = 1)
        {
            // Temporary board to store the state of the next generation
            bool[,] newState = new bool[BoardWidth * 2, BoardHeight * 2];
            // Loop for the number of generations to simulate without drawing yet, default is 1 generation
            for (int step = 0; step < steps; step++)
            {
                // Loop for each cell in the grid
                for (int y = 0; y < BoardHeight * 2; y++)
                {
                    for (int x = 0; x < BoardWidth * 2; x++)
                    {
                        // Determine the number of living neighbours that the cell has
                        switch (GetNeighbours(x, y))
                        {
                            case 0:
                            case 1:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                                // In the case of these number of neighbours, kill the cell at the current position in the next generation
                                newState[x, y] = false;
                                break;
                            case 3:
                                // In the case of 3 neighbours, set the cell at the current position to alive in the next position
                                newState[x, y] = true;
                                break;
                            case 2:
                                // In the case of 2 neighbours, copy the cell at the current position from the current to the next generation
                                newState[x, y] = state[x, y];
                                break;
                            default:
                                break;
                        }
                    }
                }
                // Copy the cells from the temporary board to the actual board
                for (int y = 0; y < BoardHeight * 2; y++)
                {
                    for (int x = 0; x < BoardWidth * 2; x++)
                    {
                        state[x, y] = newState[x, y];
                    }
                }
            }
            // Redraw the screen with the updated grid
            gameScreen.Invalidate();
        }

        // Called each time the simulation viewport is invalidated, draws the state of the grid to the screen
        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Loop for each cell in the grid
            for (int y = 0; y < BoardHeight; y++)
            {
                for (int x = 0; x < BoardWidth; x++)
                {
                    // Draw a rectangle at the corresponding position to the cell on the grid to the screen, white if the cell is alive, black if the cell is dead
                    graphics.FillRectangle(state[x + BoardWidth / 2, y + BoardHeight / 2] ? Brushes.White : new SolidBrush(Color.FromArgb(32, 32, 32)), new Rectangle(x * TileSize + BorderWidth, y * TileSize + BorderWidth, TileSize - BorderWidth * 2, TileSize - BorderWidth * 2));
                }
            }
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        // Called when the play/pause button is clicked
        private void playButton_Click(object sender, EventArgs e)
        {
            // Toggle the simulation to either playing or paused
            playing = !playing;
            // Disable other user controls if the simulation is playing
            randomButton.Enabled = !playing;
            clearButton.Enabled = !playing;
            stepButton.Enabled = !playing;
            // Toggle the text on the button
            playButton.Text = playButton.Text == "Play" ? "Pause" : "Play";
        }

        // Called when the step button is clicked
        private void stepButton_Click(object sender, EventArgs e)
        {
            // Skip the number of generations stored in the step size variable and redraw the screen
            RedrawScreen(stepSize);
        }

        // Called when the settings button is clicked
        private void settingsButton_Click(object sender, EventArgs e)
        {
            // Stop the simulation timer
            timer.Stop();
            // Open the settings form
            (new SettingsForm()).ShowDialog();
        }

        // Called whent the random button is clicked
        private void randomButton_Click(object sender, EventArgs e)
        {
            // Set each of the cells in the grid to dead or alive randomly
            Random rng = new Random();
            for (int y = 0; y < BoardHeight * 2; y++)
            {
                for (int x = 0; x < BoardWidth * 2; x++)
                {
                    state[x, y] = rng.Next(0, 2) == 0;
                }
            }
            // Redraw the screen
            gameScreen.Invalidate();
        }

        // Called when the clear button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Set each of the cells in the grid to dead
            for (int y = 0; y < BoardHeight * 2; y++)
            {
                for (int x = 0; x < BoardWidth * 2; x++)
                {
                    state[x, y] = false;
                }
            }
            // Redraw the screen
            gameScreen.Invalidate();
        }

        // Called when the mouse clicks down on the simulation viewport
        private void gameScreen_MouseDown(object sender, MouseEventArgs e)
        {
            // Only allows drawing on the grid while the simulation is paused
            if (!playing)
            {
                // Variable that stores whether the mouse button is currently depressed
                drawing = true;
                // Set the current drawing "brush color" to the inverse of the cell that was clicked
                currentBrush = !state[e.Location.X / TileSize + BoardWidth / 2, e.Location.Y / TileSize + BoardHeight / 2];
                // Set the cell to that new "brush color"
                state[e.Location.X / TileSize + BoardWidth / 2, e.Location.Y / TileSize + BoardHeight / 2] = currentBrush;
                // Redraw the screen
                gameScreen.Invalidate();
            }
        }

        private void gameScreen_MouseMove(object sender, MouseEventArgs e)
        {
            // If the mouse button is depressed
            if (drawing)
            {
                // Minor optimization to prevent redrawing every time the mouse is moved
                if (state[e.Location.X / TileSize + BoardWidth / 2, e.Location.Y / TileSize + BoardHeight / 2] != currentBrush)
                {
                    // Set the cell that the mouse is hovering over to the same state as the first one
                    state[e.Location.X / TileSize + BoardWidth / 2, e.Location.Y / TileSize + BoardHeight / 2] = currentBrush;
                    // Redraw the screen
                    gameScreen.Invalidate();
                }
            }
        }

        // Called when the mouse click is released
        private void gameScreen_MouseUp(object sender, MouseEventArgs e)
        {
            // The mouse button is no longer depressed
            drawing = false;
        }
    }
}
