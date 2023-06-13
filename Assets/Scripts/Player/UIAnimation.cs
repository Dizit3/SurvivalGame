using DG.Tweening;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    [SerializeField] RectTransform inventoryUITrans;
    private bool isOpened = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !isOpened)
        {
            inventoryUITrans.DOAnchorPos(Vector2.zero, 1f);

            isOpened = true;

        }
        else if (Input.GetKeyDown(KeyCode.I) && isOpened)
        {
            inventoryUITrans.DOAnchorPos( new Vector2(0, 1100f), 1f);

            isOpened = false;
        }

    }
}
