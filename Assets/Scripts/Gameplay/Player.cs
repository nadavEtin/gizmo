using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    #region Variables

    private readonly IWeapon _weapon;
    private readonly ISaveData _dataSaver;

    #endregion

    #region Methods

    public Player(IWeapon weapon, ISaveData dataSaver)
    {
        _weapon = weapon;
        _dataSaver = dataSaver;
        //_dataSaver.VariablesToBeSaved("currentAmmo", _weapon.GetCurrentAmmo());
        _dataSaver.SubscribeToSaveEvent(SavePlayerData);
    }

    public void Shot(IDamagable damagable)
    {
        _weapon.Fire(damagable);
    }

    private void SavePlayerData()
    {
        _dataSaver.SavePrimitive("currentAmmo", _weapon.GetCurrentAmmo());
    }

    #endregion
}