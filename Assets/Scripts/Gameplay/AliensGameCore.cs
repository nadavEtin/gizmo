using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        #region Variables

        private Player _player;
        private IDamagable _damagable = new Alien();
        private DataSaverJSON _dataSaverJson = new DataSaverJSON();

        #endregion

        #region Methods

        public AliensGameCore()
        {
            _player = new Player(new Shotgun(), _dataSaverJson);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _player.Shot(_damagable);
            }
        }

        public void SaveGameData()
        {
            _dataSaverJson.InvokeEvent();
        }
    }

    #endregion
}