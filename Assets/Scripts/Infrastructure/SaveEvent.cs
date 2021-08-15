using UnityEngine.Events;

public class SaveEvent : BaseEvent
{
    #region Methods

    public SaveEvent()
    {
        _noArgsEvent = new UnityEvent();
    }

    public void SubscribeToSaveEvent(UnityAction func)
    {
        _noArgsEvent.AddListener(func);
    }

    public void InvokeSaveEvent()
    {
        _noArgsEvent.Invoke();
    }

    #endregion
}