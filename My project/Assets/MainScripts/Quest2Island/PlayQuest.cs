using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts
{
    public class PlayQuest : MonoBehaviour
    {
        public Vector3 position;
        public PlayerInfo playerStorage;

        public void NewLevel()
        {
            playerStorage.initialValue = position;
            SceneManager.LoadScene(2);
        }
    }
}
