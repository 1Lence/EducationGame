using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts.Quest2Island
{
    public class PlayQuest : MonoBehaviour
    {
        public void NewLevel()
        {
            SceneManager.LoadScene(2);
        }
    }
}
