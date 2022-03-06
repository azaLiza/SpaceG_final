using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAsteroid : MonoBehaviour
{
    private Vector3 rightBottomCameraBorder;
    private Vector3 leftBottomCameraBorder;
    private float randomLocation;
    private Vector3 siz;
    //1 - La vitesse de deplacement
    public Vector2 speed;

    //2 - Stockage du mouvement
    private Vector2 movement;

    void Start()
    {
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));
        

    }

    void DestroyGameObject(){
        Destroy(gameObject);
    }


    // Update is called once per frame
   void Update()
    {
        
        randomLocation = Random.Range(-5.0f,5.0f);
        siz.x = gameObject.GetComponent<SpriteRenderer> ().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
        movement = new Vector3(speed.x,0,0 );

        GetComponent<Rigidbody2D> ().velocity = movement;

        
        if(transform.position.x <= (leftBottomCameraBorder.x-siz.x/2)){
            //transform.position = new Vector3 (rightBottomCameraBorder.x+(siz.x/2),randomLocation,0);
            DestroyGameObject();
            //OnDestroy();

        }        
    }
    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.name == "Ship" )
        {
          //Debug.Log(collider.name);

          // Destroy life objects
          if (GameObject.FindGameObjectWithTag("Life1")) (GameObject.FindGameObjectWithTag("Life1")).AddComponent<fadeOut>();
          //else if (GameObject.FindGameObjectWithTag("Life2")) Destroy(GameObject.FindGameObjectWithTag("Life2"));
          //else if (GameObject.FindGameObjectWithTag("Life3")) Destroy(GameObject.FindGameObjectWithTag("Life3"));
          //else if (GameObject.FindGameObjectWithTag("Life4")) Destroy(GameObject.FindGameObjectWithTag("Life4"));
          else if (GameObject.FindGameObjectWithTag("Life2")) (GameObject.FindGameObjectWithTag("Life2")).AddComponent<fadeOut>();
          else if (GameObject.FindGameObjectWithTag("Life3")) (GameObject.FindGameObjectWithTag("Life3")).AddComponent<fadeOut>();
          else if (GameObject.FindGameObjectWithTag("Life4")) (GameObject.FindGameObjectWithTag("Life4")).AddComponent<fadeOut>();

          DestroyGameObject();
        }
    }

    
     // void OnDestroy(){
       //  Vector3 tmpPos = new Vector3 (rightBottomCameraBorder.x+(siz.x/2),randomLocation,0);
      //   GameObject gY = Instantiate(Resources.Load("Asteroid"), tmpPos, Quaternion.identity) as GameObject;
     //}
}
