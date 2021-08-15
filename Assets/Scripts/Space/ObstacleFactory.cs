using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleFactory : MonoBehaviour
{
    [SerializeField] private Object _obstaclePrefabRef;

    public virtual GameObject Create()
    {
        var instance = Instantiate(_obstaclePrefabRef) as GameObject;
        return Adjust(instance);
    }

    protected abstract GameObject Adjust(GameObject obstacle);
}