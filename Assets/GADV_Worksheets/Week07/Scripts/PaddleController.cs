using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes.brick_breaker_script
{
    public class PaddleController : MonoBehaviour
    {
        private Rigidbody2D _myRB;
        private Vector2 _direction;
        public float speed = 50.0f;

        // Start is called before the first frame update
        void Start()
        {
            _myRB = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                _direction = Vector2.left;
            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                _direction = Vector2.right;
            }
            else
            {
                _direction = Vector2.zero;
            }
        }

        private void FixedUpdate()
        {
            if (_direction == Vector2.zero)
            {
                return;
            }

            _myRB.AddForce(_direction*speed);
        }
    }
}