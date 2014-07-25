#pragma strict
/*BenjoeRiveRavidal - Lead Programmer/GameDesigner
  MervinReyesPedraja - 3D modeler
  NelviePasculadoBanas - Clothing/Documentation
*/

static var LoadingScreenOn = true;

//Loading Textures
var loading1 : Texture2D;
var loading2 : Texture2D;
var loading3 : Texture2D;


function Start () 
{
	if(Loading_Screen.LoadingScreenOn == true)
	{
	
		Loading_Screen.LoadingScreenOn = false;
		guiTexture.enabled = false;
	}
}

function Update () {



if(Loading_Screen.LoadingScreenOn == true)
{
			RandomPic();
			guiTexture.enabled = true;
		
	}
  
}
	
function RandomPic()
{

		var randPic = Random.Range(0 , 2);
		var chosenPicture = randPic;
	
	 
	switch(chosenPicture){
	
	case 0:
	
		guiTexture.texture = loading1;
		break;
		
	case 1:
	
		guiTexture.texture = loading2;
		break;
		
	case 2:
		guiTexture.texture = loading3;
		break;

	}
}





