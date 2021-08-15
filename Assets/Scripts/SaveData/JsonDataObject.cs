using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonDataObject<TPrimitive> : IDataObject
{
    #region Properties

    public string[] _keys { private set; get; }
    public TPrimitive[] _vals { private set; get; }

    #endregion

    #region Methods

    public JsonDataObject(string[] keys, TPrimitive[] primitiveVals)
    {
        _keys = keys;
        _vals = primitiveVals;
    }

    #endregion
}