using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts.Quest2Island
{
    public class LeaveQuest : MonoBehaviour
    {
        public void Leave()
        {
            SceneManager.LoadScene(1);
        }
    }
}
