
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    public PostProcessVolume volumen;
    private Bloom _bloom;
    private Vignette _vignette;

    void Start()
    {
        volumen.profile.TryGetSettings(out _bloom);
        volumen.profile.TryGetSettings(out _vignette);
    }

   
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            _bloom.intensity.value = 100;
            _vignette.intensity.value = 1;
        }
        if (Input.GetKeyDown("e"))
        {
            _bloom.intensity.value = 10;
            _vignette.intensity.value = 0.5f;
        }
    }
}
