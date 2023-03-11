using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side : MonoBehaviour
{
    [SerializeField] private Vector3 raycastOffset;
    [SerializeField] private Vector3 raycastVector;
    [SerializeField] private SideName sideName;
    public Card GetTarget()
    {
        LayerMask hitLaterMask = 1 << LayerMask.NameToLayer("Cards");
        //hitLaterMask |= 1 << LayerMask.NameToLayer("Wall");
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position + this.raycastOffset, this.raycastVector, 1f, hitLaterMask);
        Debug.Log(hit.transform.gameObject.name);
        return hit.transform.gameObject.GetComponent<Card>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(this.transform.position + this.raycastOffset, this.raycastVector);
    }

}

public enum SideName
{
    UP = 0,
    RIGHT = 1,
    DOWN = 2,
    LEFT = 3
}
