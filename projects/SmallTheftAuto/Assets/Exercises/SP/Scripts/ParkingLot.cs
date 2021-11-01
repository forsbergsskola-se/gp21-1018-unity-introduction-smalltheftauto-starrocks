using UnityEngine;

public class ParkingLot : MonoBehaviour
{
    public bool hasCar;
    public GameObject carPrefab;

    private void Start()
    {
        if (hasCar) Instantiate(carPrefab, this.transform.position, transform.rotation);
    }
}
