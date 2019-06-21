using UnityEngine;
using UnityEngine.SceneManagement;

public class movementScript : MonoBehaviour
{
    public float speed = 7f;
    int life = 10;
    int coins = 0;
    private Rigidbody2D rig;

    private bool faceRight = false;
    public float jumpForce;
    private bool IsGround;
    public float checkRadius;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    private int extraJumps;
    public int extraJumpsValue;
    Animator MyAnim;

    void Start()
    {
        extraJumps = extraJumpsValue;
        rig = GetComponent<Rigidbody2D>();
        MyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move;
        IsGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        move = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(move * speed, rig.velocity.y);
        if (IsGround == true)
        {
            extraJumps = extraJumpsValue;
        }


        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rig.velocity = Vector2.up * jumpForce;
            extraJumps--;
            //rig.AddForce(Vector2.up * 7, ForceMode2D.Impulse);
        }


        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && IsGround == true) {
            rig.velocity = Vector2.up * jumpForce;
        }

        if (move > 0 && !faceRight)
            flip();
        else if (move < 0 && faceRight)
            flip();
        MyAnim.SetBool("IsGround", IsGround);
        MyAnim.SetFloat("Speed", Mathf.Abs(rig.velocity.x));
    }
	void OnCollisionEnter2D(Collision2D shit){
		if(shit.gameObject.tag=="fbomb"){
			if(life==1){
				reloadLevl();
			}
			life--;
            Destroy(shit.gameObject);
        }
		if(shit.gameObject.tag=="fhealt" & life<10){
			life++;
            Destroy(shit.gameObject);
        }
        if (shit.gameObject.tag == "fcoin")
        {
            if (coins == 9)
            {
                SceneManager.LoadScene("Airlines");
            }
            coins++;
            Destroy(shit.gameObject);
        }
    }
	void reloadLevl(){
		Application.LoadLevel(Application.loadedLevel);
	}
	void OnGUI(){
		GUI.Box(new Rect(0,0,100,30),"Life: "+life + " Coins: " + coins);
	}
    void flip() // поворот
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}