using Unity.VisualScripting;
using UnityEngine;

public class SpawnFire : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    private void OnDestroy()
    {
        Instantiate(_fire, transform.position, transform.rotation);
    }
}
