
using System;
using UnityEngine;
using DG.Tweening;

 public class Pickaxe : Tool
{
    private int durability;
    private int efficiency = 5;



    public override GameObject Equip()
    {
        return gameObject;
    }

    public override void Use()
    {
        RunAnimation();
    }

    private void RunAnimation()
    {
      transform.DOMove(new Vector3())

    }

    public void AnimationEnd()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("TryToUsePickAxe");

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 10f))
            {
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.blue, 100f);
                if (hit.collider.gameObject.TryGetComponent<MinableResource>(out MinableResource minable))
                {
                    Debug.Log("UsePickAxeSuccessful");
                    minable.Mine(efficiency);
                }
            }
        }
    }
}

