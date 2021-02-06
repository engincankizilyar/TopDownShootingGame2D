using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {


	public float speed;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>(); // script dosyasının içerisinden unity'de oluşturduğumuz animator'e erişmiş oluyoruz.

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) { // mouse'un sol buton'u tıklandıysa:
			anim.SetTrigger("Attack");
		}
	}

	void FixedUpdate(){
		// Player'ı mouse'un bulunduğu noktaya doğru yöneltme işlemi:
		var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // piksel cinsinde mouse'un ekranın tam olarak nerede olduğunu saptıyoruz.
		Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward); // Vector3.forward şu ifade ile aynı anlamdadır -> new Vector3(0,0,1).

		transform.rotation = rot;
		transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z);

		// klavyeden girilen tuşa göre de yön değiştirtme işlemi:
		float input = Input.GetAxis("Vertical"); // klavyeden düşey (y) eksende tuşlara ne kadar basıldığını elde ediyoruz.
		rigidbody2D.AddForce (gameObject.transform.up * speed * input);
	}
}
