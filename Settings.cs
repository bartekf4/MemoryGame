namespace MemoryGame
{
    /// <summary>
    ///     Class <c>Settings</c> is a singleton class holding the values which can be modified.
    /// </summary>
    internal class Settings
    {
        private static Settings _instance;


        private Settings()
        {
        }

        /// <summary>
        ///     Field <c>BoardWidthMax</c> holds the maximum width of the screen.
        /// </summary>
        public int BoardWidthMax { get; } = 1600;

        /// <summary>
        ///     Field <c>BoardWidthMin</c> holds the minimum width of the screen.
        /// </summary>
        public int BoardWidthMin { get; } = 800;

        /// <summary>
        ///     Field <c>BoardHeightMax</c> holds the maximum height of the screen.
        /// </summary>
        public int BoardHeightMax { get; } = 900;

        /// <summary>
        ///     Field <c>BoardHeightMax</c> holds the minimum height of the screen.
        /// </summary>
        public int BoardHeightMin { get; } = 600;

        /// <summary>
        ///     Field <c>BoardWidth</c> hold the width of the screen.
        /// </summary>
        public int BoardWidth { get; set; } = 1080;

        /// <summary>
        ///     Field <c>BoardHeight</c> holds the height of the screen.
        /// </summary>
        public int BoardHeight { get; set; } = 720;

        public int VisibilityTime { get; set; } = 1;
        public int VisibilityTimeMax { get; } = 10;


        public int InitVisibilityTime { get; set; } = 15;
        public int InitVisibilityTimeMax { get; } = 60;


        public static Settings GetInstance()
        {
            return _instance ?? (_instance = new Settings());
        }
    }
}