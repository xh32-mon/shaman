using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovement movement { get; set; }

        private void Awake()
        {
            movement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            if (movement != null)
            {
                float x = Input.GetAxis("Horizontal");
                float y = Input.GetAxis("Vertical");
                Vector2 input = new Vector2(x, y);

                movement.Move(input * movement.speed);
            }
        }
    }
}
