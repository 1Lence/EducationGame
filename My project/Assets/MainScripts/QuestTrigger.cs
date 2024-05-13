using UnityEngine;

namespace MainScripts
{
    public class QuestEnter : MonoBehaviour
    {
        public Animator[] Image;

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                foreach (Animator anim in Image)
                {
                    anim.SetTrigger("IsTriggered");
                }
            }
        }
    
        public void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                foreach (Animator anim in Image)
                {
                    anim.SetTrigger("IsTriggered");
                }
            }
        }
    }
}
