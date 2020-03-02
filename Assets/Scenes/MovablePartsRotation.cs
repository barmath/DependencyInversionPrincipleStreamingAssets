using UnityEngine;

public class MovablePartsRotation : IBuildObject
{
    public void ReadInput(){
        
        Debug.Log("Creating Movable Rotation Obj ");
    }
    
    public float Thrust{ get; private set; }
    public float Rotation{ get; private set; }
}
