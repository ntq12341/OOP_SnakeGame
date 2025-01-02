namespace WinFormsApp4;

public partial class Menu : Form
{
    // Người chơi
    Player _player;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="player">người chơi</param>
    public Menu(Player player)
    {
        InitializeComponent();
        _player = player;
    }

    /// <summary>
    /// Sự kiện nhấn vào button Level 1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_level1_Click(object sender, EventArgs e)
    {
        SnakeGame snakeGame = new SnakeGame(_player, 1);
        this.Hide();
        snakeGame.ShowDialog();
        this.Close();
    }

    /// <summary>
    /// Sự kiện nhấn vào button Level 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_level2_Click(object sender, EventArgs e)
    {
        SnakeGame snakeGame = new SnakeGame(_player, 2);
        this.Hide();
        snakeGame.ShowDialog();
        this.Close();
    }

    /// <summary>
    /// Sự kiện nhấn vào button Level 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void button_level3_Click(object sender, EventArgs e)
    {
        SnakeGame snakeGame = new SnakeGame(_player, 3);
        this.Hide();
        snakeGame.ShowDialog();
        this.Close();
    }

    /// <summary>
    /// Sự kiện nhấn vào button Quit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_quit_Click(object sender, EventArgs e)
    {
        this.Close();
        Application.Exit();
    }

    /// <summary>
    /// Sự kiện nhấn vào button Log Out
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_logOut_Click(object sender, EventArgs e)
    {
        this.Hide();
        LogIn logIn = new LogIn();
        logIn.ShowDialog();
        this.Close();
    }

    /// <summary>
    /// Sự kiện nhấn vào button High Score
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_highScore_Click(object sender, EventArgs e)
    {
        this.Hide();
        HighScore highScore = new HighScore(_player);
        highScore.ShowDialog();
        this.Close();
    }
}
