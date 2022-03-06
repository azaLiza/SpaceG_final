using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShoot : MonoBehaviour
{

    public Vector2 speed;
    private Vector2 mouvement;
    public GameObject[] asteroid;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouvement = new Vector2(
            speed.x,
            speed.y
            );

        GetComponent<Rigidbody2D> ().velocity = mouvement;
    }


void OnTriggerEnter2D(Collider2D collider) {

if(collider.name == "Asteroid"){
    // Add the fade script to the gameObject containing this script
    collider.gameObject.AddComponent<fadeOut>();

    //GameState.Instance.addScorePlayer(1);

    // Shoot destroy
    Destroy (gameObject); }
    }
}

/*
void FixedUpdate(){
GameObject.FindWithTag ("scoreLabel").GetComponent<Text>().text = "" + scorePlayer; }

public void addScorePlayer(int toAdd) {
scorePlayer += toAdd;
}
public int getScorePlayer(){
return scorePlayer; }


public void touchBuronSound()
{
MakeSound(playerShotSound);
}
/// Play a sound
private void MakeSound(AudioClip originalClip)
{
AudioSource.PlayClipAtPoint(originalClip, transform.posi'on);
}*/
