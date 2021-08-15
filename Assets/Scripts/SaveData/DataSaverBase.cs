using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class DataSaverBase : ISaveData
{
    #region Variables

    protected Dictionary<string, object> _variablesToSave = new Dictionary<string, object>();
    protected SaveEvent _saveEvent = new SaveEvent();

    #endregion

    #region Methods

    public void VariablesToBeSaved(string varName, object primitiveVar)
    {
        _variablesToSave.Add(varName, primitiveVar);
    }

    public void SavePrimitive(string name, string data)
    {
        throw new System.NotImplementedException();
    }

    public virtual void SavePrimitive(string name, int data)
    {
        throw new System.NotImplementedException();
    }

    public void SavePrimitive(string name, float data)
    {
        throw new System.NotImplementedException();
    }

    public abstract void SaveAllData();

    public void SubscribeToSaveEvent(UnityAction func)
    {
        _saveEvent.SubscribeToSaveEvent(func);
    }

    public void InvokeEvent()
    {
        _saveEvent.InvokeSaveEvent();
    }

    #endregion
}