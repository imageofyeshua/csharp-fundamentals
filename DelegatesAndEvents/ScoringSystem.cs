public class ScoringSystem
{
    public delegate void ScoredEvent();
    public event ScoredEvent OnScored;

    public void Score()
    {
        WriteLine("Scoring...");
        if (OnScored != null)
        {
            OnScored.Invoke();
        }
        else
        {
            WriteLine("Nothing to invoke");
        }
    }
}
