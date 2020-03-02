using UnityEngine;

public class MovablePartsStraight: IBuildObject
{
    public void ReadInput(){
        Debug.Log("Creating Movable Straight Obj ");
    }
    
    public float Thrust{ get; private set; }
    public float Rotation{ get; private set; }
}
