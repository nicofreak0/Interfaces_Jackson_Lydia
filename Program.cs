namespace Interfaces_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prints to console the answers to esrb genre and title with the describe and PlayGame methods
            Game myGame = new Game("M", "FPS", "Borderlands");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            //prints to console the answers to esrb genre and title with the describe and PlayMovie methods
            Movie myMovie = new Movie("PG-13", "Heist-Thriller", "Now You See Me");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}