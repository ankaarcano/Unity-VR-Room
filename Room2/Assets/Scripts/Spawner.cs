using UnityEngine;
using UnityEngine.Networking;

public class Spawner : NetworkBehaviour {
	
	public GameObject Fotelprefab;
	public GameObject Chairprefab;
	//public GameObject Cameraprefab;

	public Transform spawnPoint1;
	//public Transform spawnPoint2;
	public Transform spawnPoint3;
	//public Transform spawnPoint4;

	public override void OnStartServer()
	{
		var fotel = (GameObject)Instantiate (Fotelprefab, spawnPoint1.position, spawnPoint1.rotation);
		var chair = (GameObject)Instantiate (Chairprefab, spawnPoint3.position, spawnPoint3.rotation);
		//var cardboard = (GameObject)Instantiate (Cameraprefab, spawnPoint4.position, spawnPoint4.rotation);

		NetworkServer.Spawn(fotel);
		NetworkServer.Spawn(chair);
		//NetworkServer.Spawn(cardboard);
	}
	//private void SpawnPlayer(NetworkConnection conn) // spawn a new player for the desired connection
	//{
		//GameObject playerObj = GameObject.Instantiate(Cameraprefab); // instantiate on server side
		//NetworkServer.AddPlayerForConnection(conn, playerObj, 0); // spawn on the clients and set owner

	//}
}
/*
public class PlayerSpawner : MonoBehaviour
{
	[SerializeField]
	private GameObject _Playerprefab = null;

	private void SpawnPlayer(NetworkConnection conn) // spawn a new player for the desired connection
	{
		GameObject playerObj = GameObject.Instantiate(_Playerprefab); // instantiate on server side
		NetworkServer.AddPlayerForConnection(conn, playerObj, 0); // spawn on the clients and set owner
	}
}
*/