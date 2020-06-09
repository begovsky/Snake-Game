namespace Project.ClassSnake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    class Settings
    {
        //Width and Height of circles
        public static int Width { get; set; }
        public static int Height { get; set; }
        //How fast the snake moves
        public static int Speed { get; set; }
        public static int Score { get; set; }
        //How many points will be added after each circle eating
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        //Properties of large food
        public static int Width2 { get; set; }
        public static int Height2 { get; set; }
        public static bool isItThousandMultiplier { get; set; }

        public static int Level { get; set; }
        public Settings()
        {
            Width = 16;
            Height = 16;
            Width2 = 24;
            Height2 = 24;
            Speed = 16;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;
            isItThousandMultiplier = false;
        }

    }
}
