using Unity.VisualScripting;
using UnityEngine;
using static Constants;

public class HookBehavior : MonoBehaviour
{
    private GameObject hookHead;  // 갈고리 헤드는 무조건 첫 번째 자식으로 고정
    private GameObject initialParent = null;
    private GameObject player = null;
    private Rigidbody rb;


    public bool isActivated = false;
    public float power = 0.5f; //갈고리 이동 속도
    public Vector3 movement; //좌우 움직임 결정

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hookHead = transform.GetChild(0).gameObject;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (isActivated)
        {
            //플레이어가 갈고리에 탑승해 있을 때만 움직임 적용
            rb.AddRelativeForce(movement * power);
        }
    }

    public void GetOnHook(Collision2D collision)
    {
        if (!isActivated && collision.collider.CompareTag(PLAYER_TAG))
        {
            Debug.Log("갈고리 탑승");
            player = collision.collider.gameObject;
            player.GetComponent<PlayerController>().hookedHook = this;
            initialParent = player.transform.parent?.gameObject;
            player.transform.SetParent(hookHead.transform);
            isActivated = true;
        }
    }

    public void GetOffHook()
    {
        if (isActivated && player != null)
        {
            Debug.Log("갈고리 하차");
            player.transform.SetParent(initialParent?.transform);
            initialParent = null;
            player.GetComponent<PlayerController>().hookedHook = null;
            isActivated = false;
            hookHead.GetComponent<HookHeadBehavior>().EnableGetOnHook();
            player = null;
        }
    }


}
