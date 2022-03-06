namespace Session2_Exercise4;

public class WaitingRoom
{
    public Action<int> NumberChange;
    private int CurrentNumber=0;
    private int TicketCount=0;

    public void RunWaitingRoom()
    {
        while (CurrentNumber < TicketCount)
        {
            NumberChange.Invoke(CurrentNumber++);
            Console.WriteLine($"Patient number {CurrentNumber} can now enter the doctor's room");
            Thread.Sleep(2000);
            DrawNumber();
        }
    }

    public int DrawNumber()
    {
        TicketCount++;
        return TicketCount;
    }
}