using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour {
    [SerializeField] private GameObject bulletPrefab;

    private BulletInputAsset input;

    private void Start() {
        input = new BulletInputAsset();
        input.Bullet.Enable();

        input.Bullet.Shoot.performed += SpawnBullet;
    }

    private void SpawnBullet(InputAction.CallbackContext obj) {
        Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
    }
}
