#pragma strict
//

public var MissAnim : GameObject;
public var BadAnim : GameObject;

public var GoodAnim : GameObject;
public var PerfectAnim : GameObject;
public var VeryGoodAnim : GameObject;


public var Miss: GUITexture;
public var Bad: GUITexture;
public var Perfect: GUITexture;
public var Good: GUITexture;
public var VeryGood: GUITexture;


function Start () {


Miss.enabled = false;
Bad.enabled = false;

//

Perfect.enabled = false;
Good.enabled = false;
VeryGood.enabled = false;

}


public function HidePerfect(){
Perfect.enabled = false;
Good.enabled = false;
VeryGood.enabled = false;
}

public function HideWrong(){

Miss.enabled = false;
Bad.enabled = false;
}


public function MissBad(){
 var displayWrong = Random.Range(0, 5);
 var chosenWrong = displayWrong;
 
 switch(chosenWrong){
 

 case 0:
 Miss.enabled = true;
 MissAnim.animation.Play();
 
 break;
 
 
 case 1:
 Bad.enabled = true;
 BadAnim.animation.Play();
 
 Miss.enabled = false;

 break;
 
 
 
 case 2:
 Bad.enabled = false;
 Miss.enabled = false;
 HidePerfect();
 Good.enabled = false;
 break;
 
 case 3:
Bad.enabled = true;
 BadAnim.animation.Play();
 break;
 
  case 4:
Miss.enabled = true;
 MissAnim.animation.Play();
 break;
 
 }
}

//////////////////////////////------------------------//////////////////////////////////////////////




public function PerfectGood(){

 var displayRight = Random.Range(0, 6);
 var chosenRight = displayRight;
 switch(chosenRight ){
 

 case 0:
Perfect.enabled = true;
PerfectAnim.animation.Play();
//----------
Good.enabled = false;
VeryGood.enabled = false;
 HideWrong();
 break;
 

 case 1:
 Good.enabled = true;
 Good.animation.Play();
 
 
 //-----
 Perfect.enabled = false;


 VeryGood.enabled = false;
 HideWrong();
 break;



 case 2:
 VeryGood.enabled = true;
 VeryGoodAnim.animation.Play();
 
 //----
  Perfect.enabled = false;
  Good.enabled = false;
 
 HideWrong();
 break;

 case 3:
 VeryGood.enabled = false;
 HideWrong();
 break;
 
 case 4:
Perfect.enabled = false;

 HideWrong();
 break;
 
  case 5:
Good.enabled = false;

 //-----
 Perfect.enabled = false;
 VeryGood.enabled = false;

 HideWrong();
 break;
 
 
 
 
 }
}
