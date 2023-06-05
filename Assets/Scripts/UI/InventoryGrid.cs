using UnityEngine;

public class InventoryGrid : MonoBehaviour
{
    public GameObject slotPrefab;
    public Transform slotsParent;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(slotPrefab, slotsParent);
        }
    }


    

}