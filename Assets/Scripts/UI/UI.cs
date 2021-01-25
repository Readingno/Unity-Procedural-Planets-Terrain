using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Planet planet;

    int resolution;
    public Slider resolution_S;
    public InputField resolution_I;

    float seaLevel;
    public Slider seaLevel_S;
    public InputField seaLevel_I;

    float C_bRougnness;
    public Slider C_bRougnness_S;
    public InputField C_bRougnness_I;

    float C_rougnness;
    public Slider C_rougnness_S;
    public InputField C_rougnness_I;

    float C_offset;
    public Slider C_offset_S;
    public InputField C_offset_I;

    float M_bRougnness;
    public Slider M_bRougnness_S;
    public InputField M_bRougnness_I;

    float M_rougnness;
    public Slider M_rougnness_S;
    public InputField M_rougnness_I;

    float M_offset;
    public Slider M_offset_S;
    public InputField M_offset_I;

    public void Resolution_S2I()
    {
        resolution = (int)resolution_S.value;
        resolution_I.text = resolution.ToString();
        planet.resolution = resolution;
        planet.GeneratePlanet();
    }

    public void Resolution_I2S()
    {
        resolution = int.Parse(resolution_I.text);
        resolution_S.value = resolution;
        planet.resolution = resolution;
        planet.GeneratePlanet();
    }

    public void SeaLevel_S2I()
    {
        seaLevel = seaLevel_S.value;
        seaLevel_I.text = seaLevel.ToString();
        planet.shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.minValue = seaLevel;
        planet.GeneratePlanet();
    }

    public void SeaLevel_I2S()
    {
        seaLevel = float.Parse(seaLevel_I.text);
        seaLevel_S.value = seaLevel;
        planet.shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.minValue = seaLevel;
        planet.GeneratePlanet();
    }

    public void C_bRougnness_S2I()
    {
        C_bRougnness = (float)C_bRougnness_S.value;
        C_bRougnness_I.text = C_bRougnness.ToString();
        planet.shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness = C_bRougnness;
        planet.GeneratePlanet();
    }

    public void C_bRougnness_I2S()
    {
        C_bRougnness = float.Parse(C_bRougnness_I.text);
        C_bRougnness_S.value = C_bRougnness;
        planet.shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.baseRoughness = C_bRougnness;
        planet.GeneratePlanet();
    }

    public void C_rougnness_S2I()
    {
        C_rougnness = (float)C_rougnness_S.value;
        C_rougnness_I.text = C_rougnness.ToString();
        planet.shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.roughness = C_rougnness;
        planet.GeneratePlanet();
    }

    public void C_rougnness_I2S()
    {
        C_rougnness = float.Parse(C_rougnness_I.text);
        C_rougnness_S.value = C_rougnness;
        planet.shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.roughness = C_rougnness;
        planet.GeneratePlanet();
    }

    public void C_offset_S2I()
    {
        C_offset = (float)C_offset_S.value;
        C_offset_I.text = C_offset.ToString();
        planet.shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.centre = new Vector3(C_offset, 0, 0);
        planet.GeneratePlanet();
    }

    public void C_offset_I2S()
    {
        C_offset = float.Parse(C_offset_I.text);
        C_offset_S.value = C_offset;
        planet.shapeSettings.noiseLayers[0].noiseSettings.simpleNoiseSettings.centre = new Vector3(C_offset, 0, 0);
        planet.GeneratePlanet();
    }

    public void M_bRougnness_S2I()
    {
        M_bRougnness = (float)M_bRougnness_S.value;
        M_bRougnness_I.text = M_bRougnness.ToString();
        planet.shapeSettings.noiseLayers[1].noiseSettings.ridgedNoiseSettings.baseRoughness = M_bRougnness;
        planet.GeneratePlanet();
    }

    public void M_bRougnness_I2S()
    {
        M_bRougnness = float.Parse(M_bRougnness_I.text);
        M_bRougnness_S.value = M_bRougnness;
        planet.shapeSettings.noiseLayers[1].noiseSettings.ridgedNoiseSettings.baseRoughness = M_bRougnness;
        planet.GeneratePlanet();
    }

    public void M_rougnness_S2I()
    {
        M_rougnness = (float)M_rougnness_S.value;
        M_rougnness_I.text = M_rougnness.ToString();
        planet.shapeSettings.noiseLayers[1].noiseSettings.ridgedNoiseSettings.roughness = M_rougnness;
        planet.GeneratePlanet();
    }

    public void M_rougnness_I2S()
    {
        M_rougnness = float.Parse(M_rougnness_I.text);
        M_rougnness_S.value = M_rougnness;
        planet.shapeSettings.noiseLayers[1].noiseSettings.ridgedNoiseSettings.roughness = M_rougnness;
        planet.GeneratePlanet();
    }

    public void M_offset_S2I()
    {
        M_offset = (float)M_offset_S.value;
        M_offset_I.text = M_offset.ToString();
        planet.shapeSettings.noiseLayers[1].noiseSettings.ridgedNoiseSettings.centre = new Vector3(M_offset, 0, 0);
        planet.GeneratePlanet();
    }

    public void M_offset_I2S()
    {
        M_offset = float.Parse(M_offset_I.text);
        M_offset_S.value = M_offset;
        planet.shapeSettings.noiseLayers[1].noiseSettings.ridgedNoiseSettings.centre = new Vector3(M_offset, 0, 0);
        planet.GeneratePlanet();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
