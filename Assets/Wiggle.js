#pragma strict

function Start () {

}


function Update () {

    if (Input.GetKeyDown ("up")) {
            var anim : Animator = GetComponent("Animator");
            anim.SetTrigger("startWiggle");

        }
}
