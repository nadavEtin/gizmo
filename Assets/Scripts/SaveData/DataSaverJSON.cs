using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSaverJSON : DataSaverBase
{
    #region Variables

    protected List<string> _dataKeys = new List<string>();
    protected List<object> _dataValues = new List<object>();

    #endregion

    #region Methods

    public override void SaveAllData()
    {
        //foreach (KeyValuePair<string, object> kvp in _variablesToSave)
        //{
        //    _dataKeys.Add(kvp.Key);
        //    _dataValues.Add(kvp.Value);
        //}

        //JsonDataObject<object> dataObj = new JsonDataObject<object>(_dataKeys.ToArray(), _dataValues.ToArray());
        //string dataAsJson = JsonUtility.ToJson(dataObj);
        //System.IO.File.WriteAllText(Application.persistentDataPath + "/AlienGameData.json", dataAsJson);
    }

    public override void SavePrimitive(string key, int val)
    {
        JsonDataObject<int> dataObject = new JsonDataObject<int>(new string[] { key }, new int[] { val });
        string dataAsJson = JsonUtility.ToJson(dataObject);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/AlienGameData.json", dataAsJson);
    }

    #endregion
}