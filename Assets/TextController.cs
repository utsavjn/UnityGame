using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TextController : MonoBehaviour {
	public Text text;
	private enum States {room, plant_1, plant_0, chair_0, chair_1, chair_2, digger, room_digger, rope, window_0, window_1, freedom,};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.room;
	}
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.room) 		{state_room();}
		else if (myState == States.plant_0) 	{state_plant_0();}
		else if (myState == States.plant_1) 	{state_plant_1();}
		else if (myState == States.chair_0) 	{state_chair_0();}
		else if (myState == States.chair_1) 	{state_chair_1();}
		else if (myState == States.chair_2) 	{state_chair_2();}
		else if (myState == States.digger) 		{state_digger();}
		else if (myState == States.room_digger) {state_room_digger();}
		else if (myState == States.rope) 		{state_rope();}
		else if (myState == States.window_0) 	{state_window_0();}
		else if (myState == States.window_1) 	{state_window_1();}
		else if (myState == States.freedom) 	{state_freedom();}
		
	}
	#region state handler methods
		void state_room() {
		text.text = "You have been kidnapped, kept in a room, and you want to escape.\n\n " +
					"By looking at the surroundings, you can find a way to escape.\n\n " +
					"There is a plant with a digger in it and a chair you have been tied into.\n\n " +
					"Press P to view Plant, D to view digger and C to view Chair" ;
		if 		(Input.GetKeyDown(KeyCode.P)) {myState = States.plant_0;}
		else if (Input.GetKeyDown(KeyCode.D)) {myState = States.digger;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.chair_0;}
	}
		void state_digger() {
		text.text = "This sharp thing is in a plant\n\n and can be used to free yourself.\n\n" +
					"Press E to interact with the digger, or R to Return to Room" ;
		if 		(Input.GetKeyDown(KeyCode.E)) {myState = States.chair_1;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.room;}
	}
		void state_plant_0() {
		text.text = "This fake plant died because someone did not pretend to water them." +
					"Keep looking for more things around you. \n\n" +
					"Press R to Return to scanning the room" ;
		if 		(Input.GetKeyDown(KeyCode.R)) {myState = States.room;}
	}

		void state_plant_1(){
		text.text = "This might be your one step closer to the freedom \n\n" +
					"Press E to interact with plant or R to Return to scanning your room" ;
		if 		(Input.GetKeyDown(KeyCode.R)) {myState = States.room_digger;}
		else if (Input.GetKeyDown(KeyCode.E)) {myState = States.window_1;}
	}
		void state_chair_0() {
		text.text = "This damn thing you're tied to, That is your life " +
					"bound and tethered to, a chair in room \n\n" +
					"Press R to Return to scanning your room" ;
		if 		(Input.GetKeyDown(KeyCode.R)) {myState = States.room;}
	}
		void state_chair_1() {
		text.text = "You carefully move the chair towards the digger in a plant,\n\n  " +
					"slowly cut the rope with an edge of the digger and hope\n\n  " +
					"that nobody overheard an activity in the room.\n\n" +
					"Press U to Untie, or R to Return to your position" ;
		if 		(Input.GetKeyDown(KeyCode.U)) {myState = States.room_digger;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.room;}
	}
		void state_chair_2() {
		text.text = "You have been tied in this thing for hours, " +
					"by looking at it won't solv the problem,\n\n" +
					"Press E to interact with the chair or Press R to return ";
		if 		(Input.GetKeyDown(KeyCode.E)) {myState = States.window_1;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.room_digger;}
	}
		void state_room_digger() {
		text.text = "Ok, now you are free from the chair,\n\n but you are still in the room," +
					"and you STILL want to escape! \n\n There is " +
					"a plant and a digger in it, a broken rope,\n\n a window that is locked, " +
					"a chair and that pesky locked door !\n\n" +
					"Press R to view rope, W for window, C to view Chair or P to view Plant" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.plant_1;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.chair_2;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.rope;}
		else if (Input.GetKeyDown(KeyCode.W)) {myState = States.window_0;}
	}
		void state_rope() {
		text.text = "You have broken the rope. !\n\n" +
					"Press S to continue to scan the room";
		if 		(Input.GetKeyDown(KeyCode.S)) {myState = States.room_digger;}
	}
		void state_window_0() {
		text.text = " This thing is Locked.\n\n" +
					" Press S to continue to Scan the room";
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.room_digger;}
	}
		void state_window_1() {
		text.text = " Use this thing to break the window, and get the fuck out.\n\n" +
					" Prees F to get Free or Press R to return.";
		if 		(Input.GetKeyDown(KeyCode.F)) {myState = States.freedom;}
		else if (Input.GetKeyDown (KeyCode.R)){myState = States.room_digger;}
	}		
		void state_freedom () {
		text.text = "Ok you are free !\n\n" +
					"Press P to play again";
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.room;}	
	}
	#endregion
	}	
		