private var blink = false;
private var counter:int = 0;
private var blinkSpeed:int = 8;
public var yourGUITexture:GUITexture;
 
function Update()
{
    if(counter == blinkSpeed)
    
    {
   
        blink = true;
        counter = 0;
    } 
    else
    
        blink = false;
 
    counter++;
}


 
function OnGUI()
{
     if(blink)
        yourGUITexture.guiTexture.enabled = true;
     
     else 
        yourGUITexture.guiTexture.enabled = false;
      

}