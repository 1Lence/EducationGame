using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts.Quest2Island
{
    public class PlayQuest2 : MonoBehaviour
    {
        public void NewLevel2()
        {
            SceneManager.LoadScene(4);
        }
    }
}
