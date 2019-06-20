using UnityEngine;
using System.Collections;

public class AnimTrigger : MonoBehaviour {
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator myAnimationController2;
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private SpriteRenderer sprite2;

	void OnTriggerEnter2D(Collider2D col)
        //При соприкосновении с бан, спрайты меняют порядок и запускается анимация
	{
        if (col.tag == "Player") {
            sprite.sortingOrder = 2;
            sprite2.sortingOrder = 3;
            myAnimationController.SetBool("playSpin", true);
            myAnimationController2.SetBool("playFace", true);

        }
    }
}
