using UnityEngine;

#if RENDERER_UNIVERSAL
#if UNITY_2021_2_OR_NEWER
using UnityEngine.Rendering.Universal;
#else
using UnityEngine.Experimental.Rendering.Universal;
#endif
#endif

namespace NotSlot.HandPainted2D.Sample
{
  [RequireComponent(typeof(ParticleSystem))]
  public sealed class CrystalFantasyFX : MonoBehaviour
  {
    #region Inspector

    [SerializeField]
    private Color color = new Color(1, 1, 1, 1);

    [SerializeField]
    [Range(0.5f, 10)]
    private float range = 2;

    [Header("Light")]
    [SerializeField]
    [Range(0.1f, 5)]
    private float intensity = 1;

    [SerializeField]
    [Range(0.1f, 10)]
    private float flickerSpeed = 2;

    [SerializeField]
    [Range(0.01f, 1)]
    private float flickerAmount = 0.5f;

    #endregion


    #region Fields

    private float _base;

    private float _counter;

#if RENDERER_UNIVERSAL
    private Light2D _light;
#endif

    #endregion


    #region MonoBehaviour

    private void OnValidate ()
    {
      // Light
#if RENDERER_UNIVERSAL
      Light2D light2D = GetComponentInChildren<Light2D>(true);
      light2D.color = color;
      light2D.intensity = intensity;
      light2D.pointLightInnerRadius = range / 4;
      light2D.pointLightOuterRadius = range;
#endif

      // Particles
      ParticleSystem particles = GetComponent<ParticleSystem>();
      ParticleSystem.MainModule mainModule = particles.main;
      mainModule.startColor = color;

      ParticleSystem.ShapeModule shape = particles.shape;
      shape.radius = range / 2;
    }

    private void Awake ()
    {
#if RENDERER_UNIVERSAL
      _light = GetComponentInChildren<Light2D>();
#endif
    }

    public void Start ()
    {
#if RENDERER_UNIVERSAL
      _base = _light.intensity;
#endif
      _counter = Random.Range(0, 10);
    }

    private void Update ()
    {
      _counter += Time.deltaTime * flickerSpeed;
#if RENDERER_UNIVERSAL
      _light.intensity = _base + Mathf.Sin(_counter) * flickerAmount;
#endif
    }

    #endregion
  }
}