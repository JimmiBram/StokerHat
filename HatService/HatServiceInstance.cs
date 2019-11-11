public class HatServiceInstance{
    
    public HatServiceInstance(){
        this.IsRunning=true;
    }
    
    //Propperties
    public bool IsRunning { get; set; }
    
    //Internal Classes
    DataUnit CollectSample(){

        return new DataUnit();
    }

    
}