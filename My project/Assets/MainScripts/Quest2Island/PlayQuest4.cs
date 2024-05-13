using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts
{
    public class PlayQuest4 : MonoBehaviour
    {
        public Vector3 position;
        public PlayerInfo playerStorage;

        public void NewLevel4()
        {
            playerStorage.initialValue = position;
            SceneManager.LoadScene(6);
        }
    }
}
