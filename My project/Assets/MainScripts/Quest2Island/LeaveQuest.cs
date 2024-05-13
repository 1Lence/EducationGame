using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts
{
    public class LeaveQuest : MonoBehaviour
    {
        public Vector3 position;
        public PlayerInfo playerStorage;

        public void Leave()
        {
            playerStorage.initialValue = position;
            SceneManager.LoadScene(1);
        }
    }
}
