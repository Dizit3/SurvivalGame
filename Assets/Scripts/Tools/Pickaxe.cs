using DG.Tweening;
using UnityEngine;

public class Pickaxe : Tool
{
    private int durability;
    private int efficiency = 5;

    private Vector3 startPos;
    private Vector3 targetPos;


    private void Awake()
    {
        startPos = new Vector3(0.45f, -0.6f, 0.56f);

        targetPos = new Vector3(0.45f - .2f, -0.6f, 0.56f + .3f);

    }

    public override GameObject Equip()
    {
        return gameObject;
    }



    public override void Use()
    {

        var Seq = DOTween.Sequence();

        Seq.Append(transform.DOLocalMove(targetPos, .1f));
        Seq.Join(transform.DOLocalRotate(new Vector3(0f, -105f, -40f), .1f));
        Seq.AppendCallback(AnimationEnd);
        Seq.Append(transform.DOLocalMove(startPos, .2f));
        Seq.Join(transform.DOLocalRotate(new Vector3(0f, -105f, -13f), .2f));


    }



    public void AnimationEnd()
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

