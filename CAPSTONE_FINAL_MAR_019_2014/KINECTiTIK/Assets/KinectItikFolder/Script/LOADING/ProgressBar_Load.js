var progressBackground : Texture;

var progressForground : Texture;

 

function DrawProgress(location : Vector2, size : Vector2, progress : float)

{

    GUI.DrawTexture(Rect(location.x, location.y, size.x, size.y), progressBackground);

    GUI.DrawTexture(Rect(location.x, location.y, size.x * progress, size.y), progressForground);

}