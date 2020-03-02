using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{

    [SerializeField]
    private PartsArray partsArray;

    private GameObject partOnProgress;

    private IBuildObject buildObject;

    private int active = 0;

    void Update() {
        if(active < 5)
        {
            Debug.Log(active); 
            loadAssets();

            if (active == 4)
                buildObject.ReadInput();

            active++;
        }   

    }

    void loadAssets()
    {

        for(int i = 0; i < partsArray.parts.Count ; i++)
        {
            Debug.Log(partsArray.parts[i].partName);

            if(partsArray.parts[i].partType == "Movable")
            {
                if(partsArray.parts[i].typeMovement == "Rotation")
                {
                    //Debug.Log("Will have Rotation Movement");
                    buildObject = new MovablePartsRotation() as IBuildObject;
                }
                else if (partsArray.parts[i].typeMovement == "Stright")
                {
                    //Debug.Log("Will have Stright Movement");
                    buildObject = new MovablePartsStraight() as IBuildObject;
                }
                
            }
            else if (partsArray.parts[i].partType == "Static")
            {
                Debug.Log("Will be static");
                buildObject = new MovablePartsRotation() as IBuildObject;
            }
        }

    }
}
