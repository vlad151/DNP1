namespace Session2_Ex6;

public class Bird
{
    public Action<string> BirdThings;
    private string[] BirdActions = new[] {"sings wierd song", "does weird mating dance", "flaps to fly aimlessly"};

    public void Run()
    {
        while (true)
        {
            var random = new Random();
            string action = BirdActions[random.Next(0, 3)];
            BirdThings?.Invoke(action);
            Console.WriteLine(action);
            Thread.Sleep(2000);
        }
    }
}