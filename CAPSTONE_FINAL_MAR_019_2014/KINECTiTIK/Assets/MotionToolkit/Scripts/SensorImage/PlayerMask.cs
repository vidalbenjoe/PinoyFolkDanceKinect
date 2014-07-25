using UnityEngine;
using System.Collections;
using OmekFramework.Common.SensorImage;
using OmekFramework.Beckon.Main;
using OmekFramework.Beckon.Data;
using OmekFramework.Common.BasicTypes;
/// <summary>
/// Show an image of a person.
/// This script update a texture on the main material or GUItexture of it's game object
/// with the images capture from a depth camera. it cut out only a specific person form the image
/// </summary>
[AddComponentMenu("Omek/Sensor Image/Player Mask")]
public class PlayerMask : MonoBehaviour
{
	/// <summary>
	/// the person to show ID
	/// </summary>
	public int personID;
    /// <summary>
    /// is the handID a handID or PlayerID
    /// </summary>
    public bool usePlayerID;
	/// <summary>
	/// What type of image to show
	/// </summary>
	public Omek.ImageType maskType;
	/// <summary>
	/// Should the image be flipped vertically
	/// </summary>
	public bool flipVertically = false;
	/// <summary>
	/// Should the image be flipped horizontally
	/// </summary>
	public bool flipHorizontally = true;
	/// <summary>
	/// a tint color for the person mask
	/// </summary>
	public Color32 maskColor = Color.white;

	private Texture2D m_texture;
	// to optimize performance we call Texture2D.SetPixels and Texture2D.Apply on separate frames.
   private bool m_firstFrame;
	// hold the OmekFramework.Beckon needed images
	private OmekFramework.Common.SensorImage.RegularImageData regularImageData;
	private ulong m_lastFrame = ulong.MaxValue;
	// will hold the pixel data
	private Color32[] m_pixels = null;

	// Use this for initialization
	void Start()
	{
		m_firstFrame = true;
		if (maskType == Omek.ImageType.IMAGE_TYPE_COLOR)
		{
			regularImageData = BeckonData.Image.RGB;
		}
		else if (maskType == Omek.ImageType.IMAGE_TYPE_DEPTH)
		{
			regularImageData = BeckonData.Image.Depth;
		}

		TryToCreateTexture();
		Update();
	}

	private void TryToCreateTexture()
	{
        int trackedObjectID = personID;
        if (usePlayerID)
        {
            trackedObjectID = BeckonManager.BeckonInstance.PlayerSelection.TrackedObjectIdOfPlayerId(personID);
        }
        if (trackedObjectID < 0)
        {
            return;
        }
		OmekFramework.Common.BasicTypes.CommonDefines.ImageFormat maskImageFormat = null;
        if (BeckonData.Persons[(uint)trackedObjectID].Mask.GetImageFormat(out maskImageFormat).IsError())
		{
			Debug.LogError("Error reading texture size.");
		}
		else
		{

			// create a texture and a color32[] to back it.
			if (maskType == Omek.ImageType.IMAGE_TYPE_MASK)
			{
				m_texture = new Texture2D(maskImageFormat.m_width, maskImageFormat.m_height, TextureFormat.ARGB32, false);
				m_pixels = new Color32[maskImageFormat.m_width * maskImageFormat.m_height];
			}
			else
			{
				OmekFramework.Common.BasicTypes.CommonDefines.ImageFormat regularImageFormat = null;
				regularImageData.GetImageFormat(out regularImageFormat);
				m_texture = new Texture2D(regularImageFormat.m_width, regularImageFormat.m_height, TextureFormat.ARGB32, false);
				m_pixels = new Color32[regularImageFormat.m_width * regularImageFormat.m_height];
			}
			m_texture.filterMode = FilterMode.Bilinear;
			m_texture.wrapMode = TextureWrapMode.Clamp;

			m_texture.SetPixels32(m_pixels);
			m_texture.Apply();

			// set the texture in the material or GUITexture
			if (renderer)
			{
				if (maskType != Omek.ImageType.IMAGE_TYPE_COLOR)
				{
					renderer.material.color = maskColor;
				}
				renderer.material.mainTexture = m_texture;
			}
			else if (GetComponent(typeof(GUITexture)))
			{
				GUITexture gui = GetComponent(typeof(GUITexture)) as GUITexture;
				gui.texture = m_texture;
			}
		}
	}

	// Update is called once per frame
	// to achieve better performance the task is split to 2: updating the color array and apply the texture
	// each of the 2 task is performed every other frame
	void Update()
	{
		if (m_texture == null)
		{
			TryToCreateTexture();
			if (m_texture == null)
			{
				return;
			}
		}
		 

		if (Time.frameCount % 2 == 0 && !m_firstFrame) // should we apply the texture this frame or update the Color32 Array
		{
			if (renderer)
			{
				if (renderer.material.mainTexture != m_texture)
				{
					renderer.material.mainTexture = m_texture;
				}
				if (maskType != Omek.ImageType.IMAGE_TYPE_COLOR)
				{
					renderer.material.color = maskColor;
				}
			}
			m_texture.Apply();
			return;
		}

		bool hasNewImage = false;
		BeckonManager.BeckonInstance.HasNewImage(m_lastFrame,out m_lastFrame,out hasNewImage);
		if (hasNewImage)
		{
            int trackedObjectID = personID;
            if (usePlayerID)
            {
                trackedObjectID = BeckonManager.BeckonInstance.PlayerSelection.TrackedObjectIdOfPlayerId(personID);
            }
            if (BeckonManager.BeckonInstance.PersonMonitor.TrackedObjectsInSystem.Contains((uint)trackedObjectID))
			{
				ReturnCode rc;
				if (maskType == Omek.ImageType.IMAGE_TYPE_MASK)
				{
					// the default image is flipped vertically, so we used !flipVertically
                    rc = UnitySensorImageRelated.UnityImageConverters.ConvertPersonMaskToColorArray(BeckonData.Persons[(uint)trackedObjectID].Mask, maskColor, flipHorizontally, !flipVertically, ref m_pixels);
				}
				else
				{
					// the default image is flipped vertically, so we used !flipVertically
                    rc = UnitySensorImageRelated.UnityImageConverters.ConvertImageToMaskedColorArray(regularImageData, BeckonData.Persons[(uint)trackedObjectID].Mask, flipHorizontally, !flipVertically, maskColor, ref m_pixels);
				}

				if (!rc.IsError())
				{
					m_texture.SetPixels32(m_pixels, 0);
					if (m_firstFrame)
					{
						m_firstFrame = false;
						m_texture.Apply();
					}
				}
			}
		}
	}
}
