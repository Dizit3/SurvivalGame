using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("TryWorldInteraction");


            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction, Color.blue, 200f);

            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Test")
                {
                    Debug.Log("SuccessfulWorldInteraction");
                }

                if (hit.collider.gameObject.TryGetComponent<Item>(out Item item))
                {
                    Inventory.Instance.AddItem(item);
                    item.gameObject.SetActive(false);
                }


            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (InventoryBelt.Instance.handheldItem != null && InventoryBelt.Instance.handheldItem.tag != "Empty")
            {
                GameObject tool = InventoryBelt.Instance.handheldItem;
                tool.GetComponent<Tool>().Use();
            }
        }


    }




}
