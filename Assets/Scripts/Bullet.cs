using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField] private int speed = 5;

    private void Update() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
