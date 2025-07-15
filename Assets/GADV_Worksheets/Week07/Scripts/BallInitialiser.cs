using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes.brick_breaker_script
{
    public class BallInitialiser : MonoBehaviour
    {
        private Rigidbody2D MyRb { get; set; }
        public float speed = 500f;

        private void Awake()
        {
            MyRb = GetComponent<Rigidbody2D>();
        }
        // Start is called before the first frame update
        private void Start()
        {
            Invoke(nameof(SetRandomTrajectory), 1f);
        }

        // Update is called once per frame
        private void SetRandomTrajectory()
        {
            Vector2 force = Vector2.zero;
            force.x = Random.Range(-0.5f, 0.5f);
            force.y = -1;

            MyRb.AddForce(force.normalized * speed);
        }
    }
}