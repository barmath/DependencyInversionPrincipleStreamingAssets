using UnityEngine;

public class AIinput : IBuildObject
{
    public void ReadInput(){
        Debug.Log("hey");
    }
    
    public float Thrust{ get; private set; }
    public float Rotation{ get; private set; }
}
