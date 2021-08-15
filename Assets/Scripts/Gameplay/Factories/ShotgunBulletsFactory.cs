using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBulletsFactory : WeaponBulletFactory
{
    #region Methods

    protected override WeaponBullet CreateInternal(float damage)
    {
        return new ShotgunBullet(damage);
    }

    #endregion
}
