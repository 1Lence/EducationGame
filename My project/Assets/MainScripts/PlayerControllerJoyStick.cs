using UnityEngine;

namespace MainScripts
{
    public class PlayerControllerJoystick : MonoBehaviour
    {
        public float speed = 1f;
        public float MoveInput;
        Rigidbody2D rb;
        public Joystick joystick;
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            MoveInput = joystick.Horizontal;
            rb.velocity = new Vector2(MoveInput * speed, rb.velocity.y);
            MoveInput = joystick.Vertical;
            rb.velocity = new Vector2(rb.velocity.x, MoveInput * speed);
        }
    }
}
