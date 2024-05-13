using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts
{
    public class PlayQuest2 : MonoBehaviour
    {
        public Vector3 position;
        public PlayerInfo playerStorage;

        public void NewLevel2()
        {
            playerStorage.initialValue = position;
            SceneManager.LoadScene(4);
        }
    }
}
