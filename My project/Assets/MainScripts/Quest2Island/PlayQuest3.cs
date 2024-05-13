using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts
{
    public class PlayQuest3 : MonoBehaviour
    {
        public Vector3 position;
        public PlayerInfo playerStorage;

        public void NewLevel3()
        {
            playerStorage.initialValue = position;
            SceneManager.LoadScene(5);
        }
    }
}
