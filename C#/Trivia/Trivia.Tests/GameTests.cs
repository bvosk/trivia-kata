namespace Trivia.Tests;

public class GameTests
{
    private static bool _notAWinner;
    
    [Fact]
    public void GoldenMaster()
    {
        var aGame = new Game();

        aGame.Add("Chet");
        aGame.Add("Pat");
        aGame.Add("Sue");

        var rand = new Random(2);
        
        do
        {
            aGame.Roll(rand.Next(5) + 1);

            if (rand.Next(9) == 7)
            {
                _notAWinner = aGame.WrongAnswer();
            }
            else
            {
                _notAWinner = aGame.WasCorrectlyAnswered();
            }
        } while (_notAWinner);
    }
}