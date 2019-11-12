using System.Timers;

public class HatServiceInstance{
    private System.Timers.Timer _mainTimer;

    public HatServiceInstance(){
        this.IsRunning=true;
        this._mainTimer = new Timer(1000);
        this._mainTimer.Elapsed += _mainTimer_Elapsed;
        
    }

    private void _mainTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        FetchAndAnalyze();
    }

    //Propperties
    public bool IsRunning { get; set; }

    //Internal functions
    private void FetchAndAnalyze()
    {

    }

    
}