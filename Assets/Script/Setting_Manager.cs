using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Setting_Manager : MonoBehaviour
{
    private static Setting_Manager instance;
    public static Setting_Manager Instance { get { return instance; } }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        // Learning Language
        LearnLanguage();

        // Learning Move UI and Vibration
        LearnMoveUI();
        LearnVibration();

        // All Music Volume
        LearnAllMusic();

        // BackGround Music Volume
        LearnBackGroundMusic();

        // UI Music Volume
        LearnUIMusic();

        // Effect Music Volume
        LearnEffectMusic();

        // Gun Music Volume
        LearnGunMusic();

        // Explosion Music Volume
        LearnExplosionMusic();

        // Pop_Up Music Volume
        LearnPop_UpMusic();

        // Drop Music Volume
        LearnDropMusic();
    }
    #region Audio
    [SerializeField] private AudioMixer allMusicMixer;

    #region AllMusic
    [SerializeField] private Slider allMusicSlider;
    private void LearnAllMusic()
    {
        allMusicSlider.value = PlayerPrefs.GetInt("AllMusic", 0);
    }
    public void AllMusicMusic(float volume)
    {
        allMusicMixer.SetFloat("AllMusic", volume);
        PlayerPrefs.SetInt("AllMusic", (int)volume);
    }
    #endregion

    #region Background
    [SerializeField] private Slider backGroundSlider;
    private void LearnBackGroundMusic()
    {
        backGroundSlider.value = PlayerPrefs.GetInt("BackGroundMusic", 0);
    }
    public void BackGroundMusic(float volume)
    {
        allMusicMixer.SetFloat("BackGround", volume);
        PlayerPrefs.SetInt("BackGroundMusic", (int)volume);
    }
    #endregion

    #region UI
    [SerializeField] private Slider uISlider;
    private void LearnUIMusic()
    {
        uISlider.value = PlayerPrefs.GetInt("UIMusic", 0);
    }
    public void UIMusic(float volume)
    {
        allMusicMixer.SetFloat("UI", volume);
        PlayerPrefs.SetInt("UIMusic", (int)volume);
    }
    #endregion

    #region Effect
    [SerializeField] private Slider effectSlider;
    private void LearnEffectMusic()
    {
        effectSlider.value = PlayerPrefs.GetInt("EffectMusic", 0);
    }
    public void EffectMusic(float volume)
    {
        allMusicMixer.SetFloat("Effect", volume);
        PlayerPrefs.SetInt("EffectMusic", (int)volume);
    }
    #endregion

    #region Gun
    [SerializeField] private Slider gunSlider;
    private void LearnGunMusic()
    {
        gunSlider.value = PlayerPrefs.GetInt("GunMusic", 0);
    }
    public void GunMusic(float volume)
    {
        allMusicMixer.SetFloat("Gun", volume);
        PlayerPrefs.SetInt("GunMusic", (int)volume);
    }
    #endregion

    #region Explosion 
    [SerializeField] private Slider explosionSlider;
    private void LearnExplosionMusic()
    {
        explosionSlider.value = PlayerPrefs.GetInt("ExplosionMusic", 0);
    }
    public void ExplosionMusic(float volume)
    {
        allMusicMixer.SetFloat("Explosion", volume);
        PlayerPrefs.SetInt("ExplosionMusic", (int)volume);
    }
    #endregion

    #region Pop_Up
    [SerializeField] private Slider pop_UpSlider;
    private void LearnPop_UpMusic()
    {
        pop_UpSlider.value = PlayerPrefs.GetInt("Pop_UpMusic", 0);
    }
    public void Pop_UpMusic(float volume)
    {
        allMusicMixer.SetFloat("Pop_Up", volume);
        PlayerPrefs.SetInt("Pop_UpMusic", (int)volume);
    }
    #endregion

    #region Drop
    [SerializeField] private Slider dropSlider;
    private void LearnDropMusic()
    {
        dropSlider.value = PlayerPrefs.GetInt("DropMusic", 0);
    }
    public void DropMusic(float volume)
    {
        if (true)
        {

        }
        allMusicMixer.SetFloat("Drop", volume);
        PlayerPrefs.SetInt("DropMusic", (int)volume);
    }
    #endregion
    #endregion

    #region Vibration
    private void LearnVibration()
    {
        canVibration = PlayerPrefs.GetInt("canVibration", canVibration ? 0 : 1) == 0 ? true : false;
        vibrationToggle.isOn = canVibration;
    }
    public static bool canVibration;
    [SerializeField] private Toggle vibrationToggle;
    public void ChangeVibration(bool isActive)
    {
        canVibration = isActive;
        PlayerPrefs.SetInt("canVibration", canVibration ? 0 : 1);
    }
    #endregion

    #region Move UI
    private void LearnMoveUI()
    {
        canMoveUI = PlayerPrefs.GetInt("canMoveUI", canMoveUI ? 0 : 1) == 0 ? true : false;
        canMoveUIToggle.isOn = canMoveUI;
    }
    public static bool canMoveUI;
    [SerializeField] private Toggle canMoveUIToggle;
    public void ChangeMoveUI(bool isActive)
    {
        canMoveUI = isActive;
        PlayerPrefs.SetInt("canMoveUI", canMoveUI ? 0 : 1);
    }
    #endregion

    #region Language
    private void LearnLanguage()
    {
        languageNumber = PlayerPrefs.GetInt("languageNumber", languageNumber);
        languageDropdown.value = languageNumber;
    }
    public static int languageNumber;
    [SerializeField] private TMP_Dropdown languageDropdown;
    public void ChangeLanguage(int langNumber)
    {
        languageNumber = langNumber;
        PlayerPrefs.SetInt("languageNumber", languageNumber);
    }
    #endregion
}