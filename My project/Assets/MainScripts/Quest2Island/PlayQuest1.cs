using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts
{
    public class PlayQuest1 : MonoBehaviour
    {
        public Vector3 position;
        public PlayerInfo playerStorage;

        public void NewLevel1()
        {
            playerStorage.initialValue = position;
            SceneManager.LoadScene(3);
        }
    }
}
