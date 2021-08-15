using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperBulletsFactory : WeaponBulletFactory
{
    #region Methods
    protected override WeaponBullet CreateInternal(float damage)
    {
        return new SniperBullet(damage);
    }

    #endregion
}
