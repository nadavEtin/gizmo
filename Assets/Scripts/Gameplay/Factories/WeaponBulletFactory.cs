using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBulletFactory
{
    #region Methods

    public virtual WeaponBullet Create(float damage)
    {
        Debug.Log("Creating bullet");
        return CreateInternal(damage);
    }

    protected abstract WeaponBullet CreateInternal(float damage);

    #endregion
}
