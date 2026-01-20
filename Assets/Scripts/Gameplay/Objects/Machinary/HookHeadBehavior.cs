using System.Collections;
using UnityEngine;

public class HookHeadBehavior : MonoBehaviour
{
    private HookBehavior hookBehavior;
    [SerializeField] private float disableDuration = 1f;

    void Start()
    {
        hookBehavior = transform.parent.GetComponent<HookBehavior>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("갈고리 헤드 충돌 감지");
        hookBehavior.GetOnHook(collision);
        GetComponent<Collider2D>().enabled = false;
    }

    public void EnableGetOnHook()
    {
        StartCoroutine(WaitAndEnable(disableDuration));
    }

    IEnumerator WaitAndEnable(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        GetComponent<Collider2D>().enabled = true;
    }
}
