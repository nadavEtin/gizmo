using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class BaseEvent
{
    #region Variables

    protected UnityEvent _noArgsEvent;
    protected UnityEvent<int> _intEvent;
    protected UnityEvent<float> _floatEvent;
    protected UnityEvent<string> _stringEvent;

    #endregion
}
