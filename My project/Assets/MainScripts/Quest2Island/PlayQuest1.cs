using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts.Quest2Island
{
    public class PlayQuest1 : MonoBehaviour
    {
        public void NewLevel1()
        {
            SceneManager.LoadScene(3);
        }
    }
}
