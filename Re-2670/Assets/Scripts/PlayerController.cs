using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{

    //public float thrusterForce;
    private Rigidbody2D rigid;
    public int health;
    public float moveSpeed;
    public GameObject levelManager;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

        print(GetComponent<Health>().GetHealth());
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //float v = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(new Vector3(h, 0f));

        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}



