using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
public class DownloadImage : MonoBehaviour
{
    private string customScreenshotPath = "Assets/Screenshots/";
    private string customScreenshotName = "screenshot";
    [SerializeField] private GameObject saveScreenshotPanel;
    [SerializeField] private Button downloadTheImageButton;
    [SerializeField] private TMP_InputField screenShotNameInputField;
    [SerializeField] private TMP_InputField PathNameInputField;
    private void Awake()
    {
        downloadTheImageButton.onClick.AddListener(CaptureScreenshot);
    }
    private void Start()
    {
        saveScreenshotPanel.SetActive(false);
    }
    public void CaptureScreenshotPanelButton()
    {
        saveScreenshotPanel.SetActive(true);
    }
    public void CaptureScreenshot()
    {
       #if UNITY_EDITOR
        saveScreenshotPanel.SetActive(false);
        UpdateNameInputField();
        UpdatePathInputField();
        string customFileName = customScreenshotName + ".png";
        string customFilePath = Path.Combine(customScreenshotPath, customFileName);
        Debug.Log(customFilePath);

        if (!Directory.Exists(customScreenshotPath))
        {
            Directory.CreateDirectory(customScreenshotPath);
            ScreenCapture.CaptureScreenshot(customFilePath);
            Debug.Log("Path did not exist but has been created! Save the screenshot again.");
            Debug.Log("Refresh to see the screenshot");
            Debug.Log("Unity Editor");
        }
        else
        {
            ScreenCapture.CaptureScreenshot(customFilePath);
            Debug.Log("Unity Editor");
        }
#else
            saveScreenshotPanel.SetActive(false);
        UpdateNameInputField();
        UpdatePathInputField();
        string customFileName = customScreenshotName + ".png";
        string customFilePath = Path.Combine(customScreenshotPath, customFileName);
        Debug.Log(customFilePath);

        if (!Directory.Exists(customScreenshotPath))
        {
            Directory.CreateDirectory(customScreenshotPath);
            ScreenCapture.CaptureScreenshot(customFilePath);
            Debug.Log("Path did not exist but has been created! Save the screenshot again.");
            Debug.Log("Build Exe");
        }
        else
        {
            ScreenCapture.CaptureScreenshot(customFilePath);
            Debug.Log("Build Exe");
        }
#endif
    }

    private void UpdateNameInputField()
    {
        customScreenshotName = screenShotNameInputField.text;      
    }
    private void UpdatePathInputField()
    {
        customScreenshotPath = PathNameInputField.text;

    }
}