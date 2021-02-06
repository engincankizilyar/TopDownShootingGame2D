using UnityEngine;
using System.Collections;

public class SwordScript : MonoBehaviour {

	public GameObject explosion; // unity'de oluşturduğumuz explosion anim'i script dosyasında elde ediyoruz.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// ışın kılıcının kendisine çarpan Enemy objesini yok etme işlemi:
	void OnTriggerEnter2D(Collider2D other){ 
		Instantiate(explosion, other.transform.position, Quaternion.identity); // Işın kılıcıyla Enemy objesi yok edilmeden explosion animasyonun gösterilmesi.
		Destroy(other.gameObject);

	}
}
