using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public float moveSpeed;
    public bool rushing = false;
    private float speedMod = 0;

    float timeLeft = 2f;

    private Rigidbody2D myRigidBody;

    private Animator myAnim;

    public GameObject bubbles;

    // Adicionar variáveis para os clipes de áudio
    public AudioClip lixoObjetoClip;
    public AudioClip lixoBombaClip;

    private AudioSource audioSource;

    // Use this for initialization
    void Start (){
        myRigidBody = GetComponent<Rigidbody2D> ();	
        myAnim = GetComponent<Animator> ();
        audioSource = GetComponent<AudioSource>(); // Inicializar o AudioSource
    }
    
    // Update is called once per frame
    void Update (){

        resetBoostTime ();
        controllerManager ();

        myAnim.SetFloat ("Speed", Mathf.Abs(myRigidBody.linearVelocity.x));
    }

    void controllerManager (){
        if (Input.GetAxisRaw ("Horizontal") > 0f) {
            transform.localScale = new Vector3(1f,1f,1f);
            movePlayer ();
        } else if (Input.GetAxisRaw ("Horizontal") < 0f) {			
            transform.localScale = new Vector3(-1f,1f,1f);
            movePlayer ();
        } else if (Input.GetAxisRaw ("Vertical") > 0f) {
            myRigidBody.linearVelocity = new Vector3 (myRigidBody.linearVelocity.x, moveSpeed, 0f);
        } else if (Input.GetAxis ("Vertical") < 0f) {
            myRigidBody.linearVelocity = new Vector3 (myRigidBody.linearVelocity.x, -moveSpeed, 0f);
        }

        if(Input.GetButtonDown("Jump") && !rushing ){
            rushing = true;
            speedMod = 2;
            Instantiate (bubbles, gameObject.transform.position, gameObject.transform.rotation);
            movePlayer ();
        }	
    }

    void movePlayer(){
        if (transform.localScale.x == 1) {
            myRigidBody.linearVelocity = new Vector3 (moveSpeed + speedMod, myRigidBody.linearVelocity.y, 0f);	
        } else {
            myRigidBody.linearVelocity = new Vector3 (- (moveSpeed + speedMod), myRigidBody.linearVelocity.y, 0f);
        }	
    }

    void resetBoostTime(){
        if (timeLeft <= 0) {
            timeLeft = 2f;
            rushing = false;
            speedMod = 0;
        } else if(rushing) {
            timeLeft -= Time.deltaTime;
        }	
    }

    public void hurt(){
        if(!rushing){
            gameObject.GetComponent<Animator> ().Play ("PlayerHurt");		
        }
    }

    
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LixoBomba")
		{
			audioSource.PlayOneShot(lixoBombaClip);
			Debug.Log("bateu no lixo bomba");
		}else{
			audioSource.PlayOneShot(lixoObjetoClip);
			Debug.Log("bateu no lixo objeto");
		}
	}
}