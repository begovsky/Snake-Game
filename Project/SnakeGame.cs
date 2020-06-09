using Project.ClassSnake;
using Project.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Project
{
    public partial class SnakeGame : Form
    {
        public static Boolean isFirstRunning { get; set; }
        public static Boolean isFirstRunningRecord { get; set; }

        private List<Circle> Snake = new List<Circle>();    //  @OOOOOO
        private Circle food = new Circle();     //Samo jedan kruzic tj. hrana
        private Circle largeFood = new Circle();
        List<Brush> brushes = new List<Brush>();
        private Brush foodColor = Brushes.Red;
        private int counter = 0; //buyuk yiyecek efekti icin kullaniliyor
        private int counter2 = 0; //
        private int rc; // record 
        private int period = 35; //kirmizi yilan efekt periodsi
        private System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        DB db;

        public SnakeGame()
        {
            InitializeComponent();

            db = new DB();

            lblGameOver.Visible = false;
            lblUsername.Visible = false;

            pbPause.Hide();
            pbPause.BackColor = Color.Transparent;

            //Set settings to default
            new Settings();

            //Set game speed and start timer

            timerRedSnakeEffect.Interval = gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += updateScreen;

            brushes.Add(Brushes.Red);
            brushes.Add(Brushes.Orange);
            brushes.Add(Brushes.DarkBlue);
            brushes.Add(Brushes.Purple);

        }

        public void StartGame()
        {
            gameTimer.Start();
            pbGameOver.Visible = false;

            isFirstRunning = true;
            isFirstRunningRecord = true;

            //Set settings to default
            new Settings();

            if (Settings.Level == 2 || Settings.Level == 3)
            {
                if (Settings.Level == 2)
                    Settings.Points = 200;
                else
                    Settings.Points = 300;

                Settings.direction = Direction.Right;
                period = 50;
            }

            counter = 0;

            //Create new player object
            Snake.Clear();  //Obrisi prethodnu zmiju
            Circle head = new Circle(); //Glava zmije

            //Eger 2. ya da 3. seviye ise yilanin hareket yonunu degistir
            if (Settings.Level == 2 || Settings.Level == 3)
            {
                head.X = 6;
                head.Y = 4;
            }
            else
            {
                head.X = 10;
                head.Y = 5;
            }

            Snake.Add(head);    //Dodajemo glavu zmiji

            label1.Text = Settings.Score.ToString();
            lblUsername.Hide();
            lblGameOver.Hide();

            GenerateFood(); //Napravi jednu vockicu

        }

        //Place random food game
        private void GenerateFood()
        {
            //Start:

            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;


            Random random = new Random();

            if (Settings.isItThousandMultiplier == true)
            {
                if (Settings.Level == 2 || Settings.Level == 3)
                {
                Start:
                    largeFood = new Circle
                    {
                        X = random.Next(3, maxXPos - 3),
                        Y = random.Next(3, maxYPos - 3)
                    };
                    for (int i = 0; i < Snake.Count; i++)
                        if (Snake[i].X == largeFood.X && Snake[i].Y == largeFood.Y)
                            goto Start;

                    for (int a = 6; a <= 20; a++)
                        if (largeFood.X == a && (largeFood.Y == 6 || largeFood.Y == 18))
                            goto Start;

                    for (int b = 4; b <= 20; b++)
                        if (largeFood.Y == b && (largeFood.X == 3 || largeFood.X == 23))
                            goto Start;
                    if (Settings.Level == 3)
                    {
                        for (int k = 0; k < 425; k += 16)
                            if ((largeFood.X <= 0 && largeFood.Y >= k) || (largeFood.X >= k && largeFood.Y <= 0))
                                goto Start;
                        if (largeFood.X == (maxXPos - 1) || largeFood.Y == (maxYPos - 1))
                            goto Start;
                    }

                }
                else
                {
                Start:
                    largeFood = new Circle
                    {
                        X = random.Next(0, maxXPos),
                        Y = random.Next(0, maxYPos)
                    };
                    for (int i = 0; i < Snake.Count; i++)
                        if (Snake[i].X == largeFood.X && Snake[i].Y == largeFood.Y)
                            goto Start;
                }

            }

            //Not allowing food to overlapp
            if (Settings.Level == 2)
            {
            Start:
                food = new Circle
                {
                    X = random.Next(0, maxXPos),
                    Y = random.Next(0, maxYPos)
                };

                for (int a = 6; a <= 20; a++)
                    if (food.X == a && (food.Y == 6 || food.Y == 18))
                        goto Start;

                for (int b = 4; b <= 20; b++)
                    if (food.Y == b && (food.X == 3 || food.X == 23))
                        goto Start;
                for (int i = 0; i < Snake.Count; i++)
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                        goto Start;
            }
            else if (Settings.Level == 3)
            {
            Start:
                food = new Circle
                {
                    X = random.Next(0, maxXPos),
                    Y = random.Next(0, maxYPos)
                };
                for (int k = 0; k < 425; k += 16)
                    if ((food.X <= 0 && food.Y >= k) || (food.X >= k && food.Y <= 0))
                        goto Start;
                if (food.X == (maxXPos - 1) || food.Y == (maxYPos - 1))
                    goto Start;
                for (int i = 0; i < Snake.Count; i++)
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                        goto Start;
            }
            else
            {
            Start:
                food = new Circle
                {
                    X = random.Next(0, maxXPos),
                    Y = random.Next(0, maxYPos)
                };
                for (int i = 0; i < Snake.Count; i++)
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                        goto Start;
            }


            //Renk secimi
            foodColor = brushes[random.Next(0, 4)];

        }

        private void updateScreen(object sender, EventArgs e)
        {

            //Check for Game Over
            if (Settings.GameOver == true)
            {

                //Check if Enter is pressed
                if (Input.keyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            //We dont want snake to colide into it's own body
            else
            {

                if (Input.keyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                }
                else if (Input.keyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                }
                else if (Input.keyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                }
                else if (Input.keyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                }

                movePlayer();

            }

            //Data gets deleted and drawn again
            pbCanvas.Invalidate();
        }

        private void movePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                    }

                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detecting Obstacles
                    if (Settings.Level == 2 || Settings.Level == 3)
                    {
                        for (int a = 6; a <= 20; a++)
                            if (Snake[i].X == a && (Snake[i].Y == 6 || Snake[i].Y == 18))
                                Die();

                        for (int b = 4; b <= 20; b++)
                            if (Snake[i].Y == b && (Snake[i].X == 3 || Snake[i].X == 23))
                                Die();
                    }
                    if (Settings.Level == 3)
                    {
                        for (int k = 0; k < 425; k += 16)
                            if ((Snake[i].X <= 0 && Snake[i].Y >= k) || (Snake[i].X >= k && Snake[i].Y <= 0))
                                Die();

                        if (Snake[i].X == (maxXPos - 1) || Snake[i].Y == (maxYPos - 1))
                            Die();
                    }
                    //Detect collision with game borders
                    else
                    {

                        if (Snake[i].Y < 0)
                            Snake[i].Y = maxYPos;
                        else if (Snake[i].X < 0)
                            Snake[i].X = maxXPos;
                        else if (Snake[i].X >= maxXPos)
                            Snake[i].X = 0;
                        else if (Snake[i].Y >= maxYPos)
                            Snake[i].Y = 0;
                    }

                    //Detect collision with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                    if (Settings.isItThousandMultiplier == true)
                    {
                        if ((Snake[0].X == largeFood.X - 1 && Snake[0].Y == largeFood.Y - 1) ||
                                    (Snake[0].X == largeFood.X - 1 && Snake[0].Y == largeFood.Y + 1) ||
                                        (Snake[0].X == largeFood.X + 1 && Snake[0].Y == largeFood.Y + 1) ||
                                            (Snake[0].X == largeFood.X && Snake[0].Y == largeFood.Y - 1) ||
                                                (Snake[0].X == largeFood.X && Snake[0].Y == largeFood.Y + 1) ||
                                                    (Snake[0].X == largeFood.X - 1 && Snake[0].Y == largeFood.Y) ||
                                                        (Snake[0].X == largeFood.X + 1 && Snake[0].Y == largeFood.Y))
                        {
                            Settings.Score += Settings.Points;
                            player.SoundLocation = "level-up.wav";
                            player.Play();
                            counter = 0;
                            Eat();
                            timerRedSnakeEffect.Start();

                        }
                        else
                            counter++;
                    }
                }
                else
                {
                    //Move Body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Eat()
        {
            //Add circle to body
            Circle food = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(food);

            if (Settings.isItThousandMultiplier == true)
                Settings.isItThousandMultiplier = false;

            //Update Total Score
            Settings.Score += Settings.Points;
            label1.Text = Settings.Score.ToString();

            if (Settings.Score % 600 == 0 && Settings.Score != 0)
            {
                Settings.isItThousandMultiplier = true;
                counter = 1;
            }

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
            pbGameOver.Visible = true;
        }

        //Gets triggered when program is build or on pbCanvas.Invalidate();

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            List<Brush> renkler = new List<Brush>   //buyuk yiyeceklerin rengi
            {
                Brushes.YellowGreen,
                Brushes.OrangeRed
            };

            if (timerRedSnakeEffect.Enabled == true)   //buyuk yiyecegi yeyince yilan efekti
                counter2++;

            if (!Settings.GameOver)
            {
                //Set colour of snake
                Brush snakeColor;

                //Draw Snake
                for (int i = 0; i < Snake.Count; i++)
                {

                    if (i == 0)                      //Eger kafaysa
                        snakeColor = Brushes.DarkSlateGray;  //Draw head
                    else   //Eger govde ise 
                    {
                        if (timerRedSnakeEffect.Enabled == true && counter2 < 22)
                        {
                            Random rnd = new Random();
                            snakeColor = renkler[rnd.Next(0, 2)];
                        }
                        else if (counter2 == 22)     //Efektin zamani bitti ise
                        {
                            timerRedSnakeEffect.Stop();
                            counter2 = 0;
                            snakeColor = Brushes.Green;
                        }
                        else
                            snakeColor = Brushes.Green; //Yoksa
                    }

                    //Draw Snake
                    canvas.FillEllipse(snakeColor,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));

                    //Draw Food
                    canvas.FillEllipse(foodColor,
                        new Rectangle(food.X * Settings.Width, food.Y * Settings.Height,
                                      Settings.Width, Settings.Height));

                    if (Settings.Level == 3)
                    {
                        for (int k = 0; k <= 416; k += 16)
                        {
                            canvas.FillEllipse(Brushes.Black,
                                new Rectangle(0, k, Settings.Width, Settings.Height));
                            canvas.FillEllipse(Brushes.Black,
                                new Rectangle(k, 0, Settings.Width, Settings.Height));
                        }

                        for (int j = 0; j <= 400; j += 16)
                        {
                            canvas.FillEllipse(Brushes.Black,
                                new Rectangle(416, j, Settings.Width, Settings.Height));
                            canvas.FillEllipse(Brushes.Black,
                                new Rectangle(j, 384, Settings.Width, Settings.Height));
                        }
                    }

                    if (Settings.Level == 2 || Settings.Level == 3)
                    {
                        for (int a = 96; a <= 320; a += 16)
                        {
                            canvas.FillEllipse(Brushes.Black,
                                new Rectangle(a, 96, Settings.Width, Settings.Height));

                            canvas.FillEllipse(Brushes.Black,
                                new Rectangle(a, 288, Settings.Width, Settings.Height));

                            for (int b = 64; b <= 320; b += 16)
                            {
                                canvas.FillEllipse(Brushes.Black,
                                new Rectangle(48, b, Settings.Width, Settings.Height));

                                canvas.FillEllipse(Brushes.Black,
                                    new Rectangle(368, b, Settings.Width, Settings.Height));
                            }

                        }
                    }
                    if (Settings.isItThousandMultiplier == true)
                    {
                        Random rnd = new Random();

                        if (counter < period && counter != 0)
                        {
                            canvas.FillEllipse(renkler[rnd.Next(0, 2)],
                        new Rectangle(largeFood.X * Settings.Width, largeFood.Y * Settings.Height,
                                      Settings.Width2, Settings.Height2));
                        }
                        else
                        {
                            largeFood.X = 1000;
                            largeFood.Y = 1000;
                            counter = 0;
                        }

                    }

                }
            }
            else
            {

                if (isFirstRunningRecord)
                {
                    isFirstRunningRecord = false;

                    db.UserRecord();

                    rc = DB.currentUser.Record;

                    if (DB.newRecord) player.SoundLocation = "newrecord.wav";
                    else player.SoundLocation = "game-over.wav";

                    player.Play();
                }

                lblGameOver.Text = "Game over.\nYour score: " + Settings.Score + "\nYour record: " + rc.ToString() + "\n\n\nTo play again press ENTER,\nTo exit press ESC.";
                lblUsername.Text = "Well played \n" + DB.currentUser.Username + " !";
                lblGameOver.Show();
                lblUsername.Show();

                if (isFirstRunning)
                {
                    isFirstRunning = false;
                }
            }
        }

        private void SnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            //Let the application known that the bottom was pressed down
            Input.changeState(e.KeyCode, true);

            if (!Settings.GameOver)
            {
                if (Input.keyPressed(Keys.Space))
                {
                    if (gameTimer.Enabled)
                    {
                        gameTimer.Stop();
                        pbPause.Show();
                    }

                    else
                    {
                        pbPause.Hide();
                        gameTimer.Start();
                    }

                }
            }
            if (Input.keyPressed(Keys.Escape))
            {
                Input.keyTable.Clear();
                Owner.Show();
                this.Close();

                MainScreen.snakeGame = new SnakeGame();
            }

        }

        private void SnakeGame_KeyUp(object sender, KeyEventArgs e)
        {
            //Let the application known that the bottom is no longer being pressed
            Input.changeState(e.KeyCode, false);
        }

        private void SnakeGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
        }


    }
}
