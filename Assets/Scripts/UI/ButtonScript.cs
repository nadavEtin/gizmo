using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GizmoLab.Infrastructure
{

    public class ButtonScript : MonoBehaviour, IButton
    {
        [SerializeField] private AppLifetimeCore _targetScript;

        #region Methods

        public void ButtonClicked()
        {
            _targetScript.SaveGameData();
        }

        #endregion
    }
}
