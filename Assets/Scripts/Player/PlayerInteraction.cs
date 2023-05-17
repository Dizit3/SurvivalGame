using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    InventoryBelt BeltInventory;

    private void Awake()
    {
        BeltInventory = Camera.main.GetComponent<InventoryBelt>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("TryWorldInteraction");


            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction,Color.blue,200f);

            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.tag == "Test")
                {
                    Debug.Log("SuccessfulWorldInteraction");
                }

            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (BeltInventory.handheldItem != null && BeltInventory.handheldItem.tag != "Empty")
            {
                GameObject tool = BeltInventory.handheldItem;
                tool.GetComponent<Tool>().Use();
            }
        }
    }





}
