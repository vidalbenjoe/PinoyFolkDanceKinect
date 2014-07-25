var track1 : AudioClip;

 
audio.clip = track1;
audio.Play();
 
var audio1Volume : float = 1.0;

 
function Update() {
    fadeOut();
 
  
}
 
function OnGUI()
{
    GUI.Label(new Rect(10, 10, 200, 100), "Audio 1 : " + audio1Volume.ToString());
   
}
 

 
function fadeOut() {
    if(audio1Volume > 0.1)
    {
        audio1Volume -= 0.1 * Time.deltaTime;
        audio.volume = audio1Volume;
    }
}