using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSaverPlayerPref : DataSaverBase
{
    public override void SaveAllData()
    {
        
    }

    public override void SavePrimitive(string name, int data)
    {
        PlayerPrefs.SetInt(name, data);
    }
}
