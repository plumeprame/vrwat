#pragma strict
 
var animator : Animator; //stores the animator component
var v : float; //vertical movements
var h : float; //horizontal movements
var sprint : float;
 
function Start () {
animator = GetComponent("mime"); //assigns Animator component when we start the game 
}
 
function Update () {
 
v = Input.GetAxis("Vertical");
h = Input.GetAxis("Horizontal");
Sprinting();
}

function fixedUpdate(){
//set the "Walk" parameter to the v axis value
animator.SetFloat ("Walking", v);
animator.SetFloat ("Turning", h);
animator.SetFloat("Sprinting", sprint);
}
 
function Sprinting () {
if(Input.GetButton("Fire1")) {
	sprint = 0.2;
}
else {
	sprint = 0.0;
}
 
}