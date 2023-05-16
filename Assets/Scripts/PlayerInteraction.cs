using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("EEEEEEEEEE");


            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction,Color.blue,200f);

            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.tag == "Test")
                {
                    Debug.Log("ITS OKAY!!");
                }

            }
        }
    }





}
