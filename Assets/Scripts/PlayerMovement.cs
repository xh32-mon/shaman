using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float m_Speed = 1.0f;

        private new Rigidbody2D rigidbody { get; set; }

        public float speed
        {
            get => m_Speed;
            set => m_Speed = value;
        }

        public Vector2 vector { get; private set; }

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            rigidbody.velocity = Vector2.ClampMagnitude(vector, speed);
        }

        public void Move(Vector2 vector)
        {
            this.vector = vector;
        }
    }
}
