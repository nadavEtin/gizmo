using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface ISaveData
{
    #region Methods

    void SavePrimitive(string name, string data);

    void SavePrimitive(string name, int data);

    void SavePrimitive(string name, float data);

    void VariablesToBeSaved(string varName, object primitiveVar);

    void SaveAllData();

    void SubscribeToSaveEvent(UnityAction func);

    #endregion
}
