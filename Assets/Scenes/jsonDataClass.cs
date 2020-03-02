using System;
using System.Collections.Generic;

[Serializable]
public class jsonDataClass
{
    public Item [] itens;
}

[Serializable]
public class Item
{
    public string partName;
    public Setting [] settings;
}

[Serializable]
public class Setting 
{
    public string partType;
    public string typeMovement;
}