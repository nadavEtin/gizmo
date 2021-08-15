using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase<TFactory> : IWeapon
    where TFactory : WeaponBulletFactory, new()
{
    #region Variables

    protected WeaponBulletFactory _factory = new TFactory();
    protected int _maxAmmoHeld = 10, _currentAmmo = 10;

    #endregion

    #region Methods

    public void Fire(IDamagable damagable)
    {
        var bullet = _factory.Create(20);
        bullet.MakeDamage(damagable);
        _currentAmmo--;
        if (_currentAmmo <= 0)
            Reload();
    }

    public void Reload()
    {
        Debug.Log("reloading");
        _currentAmmo = _maxAmmoHeld;
    }

    int IWeapon.GetCurrentAmmo()
    {
        return _currentAmmo;
    }

    #endregion
}