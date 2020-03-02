using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonSocket : MonoBehaviour
{

    [SerializeField]
    private string jsonURL;

    public jsonDataClass jsnData;

    [SerializeField]
    private PartsArray partsArray;
    [SerializeField]
    private PartsObject partsObject;

    private IBuildObject buildObject;

    void Start()
    {
        StartCoroutine(getData());
        partsArray.parts.Clear();

    }

    IEnumerator getData(){

        Debug.Log("Processig Data, wait");
        WWW _www = new WWW(jsonURL);
        yield return _www;
        if(_www.error == null){
            processJsonData(_www.text);
        }else{
            Debug.Log("Error loading Json");
        }
    }


    private void processJsonData(string _url){

        jsnData = JsonUtility.FromJson<jsonDataClass>(_url);

        parser();
        show();

    }

    private void parser(){

        for(int i = 0; i < jsnData.itens.Length ; i++){

            partsObject = (PartsObject) ScriptableObject.CreateInstance( typeof(PartsObject) );
            var clone = Instantiate(partsObject);

            partsObject.partName = jsnData.itens[i].partName;
            partsObject.partType = jsnData.itens[i].settings[0].partType;
            partsObject.typeMovement = jsnData.itens[i].settings[0].typeMovement;

            partsArray.parts.Add(partsObject);

        }
    }

    private void show(){

        for(int i = 0; i < jsnData.itens.Length ; i++){

            Debug.Log(jsnData.itens[i].partName);
            Debug.Log(jsnData.itens[i].settings[0].partType);
            Debug.Log(jsnData.itens[i].settings[0].typeMovement);

        }
        
    }


    //Send the information to the json parser part object array

}