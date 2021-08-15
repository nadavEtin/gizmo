using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBullet
{
    #region Variables

    protected float _damage;

    #endregion

    #region Methods

    protected WeaponBullet(float damage)
    {
        _damage = damage;
    }

    public void MakeDamage(IDamagable damagable)
    {
        damagable.TakeDamage(_damage);
    }

    #endregion
}
