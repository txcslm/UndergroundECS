using System.Collections.Generic;
using System.Linq;
using Code.Infrastructure.PersistentProgresses;
using Code.Infrastructure.Projects;
using UnityEngine;

namespace Code.Infrastructure.SaveLoadServices
{
  public class PlayerPrefsSaveLoad : ISaveLoadService
  {
    private readonly PersistentProgressService _progressService;
    private readonly ProjectData _projectData;

    public PlayerPrefsSaveLoad(PersistentProgressService progressService, ProjectData projectData)
    {
      _progressService = progressService;
      _projectData = projectData;
    }

    public List<IProgressReader> ProgressReaders { get; } = new();

    public void SaveProgress(string saver)
    {
      UpdateProgressWriters();
      WritePlayerPrefs();
    }

    public void LoadProgress()
    {
      ReadPlayerPrefs();
      UpdateProgressReaders();
    }

    public void DeleteSaves()
    {
      PlayerPrefs.DeleteKey(ProgressKey());
    }

    private string ProgressKey() =>
      $"{_projectData.ConfigId}_progress";

    private void UpdateProgressReaders()
    {
      foreach (IProgressReader progressReader in ProgressReaders)
        progressReader.ReadProgress(_progressService.ProjectProgress);
    }

    private void UpdateProgressWriters() =>
      ProgressReaders
        .OfType<IProgressWriter>()
        .ToList()
        .ForEach(progressWriter => progressWriter.WriteProgress(_progressService.ProjectProgress));

    private void WritePlayerPrefs() =>
      PlayerPrefs.SetString(ProgressKey(), JsonUtility.ToJson(_progressService.ProjectProgress));

    private void ReadPlayerPrefs()
    {
      if (PlayerPrefs.HasKey(ProgressKey()))
        _progressService.LoadProgress(PlayerPrefs.GetString(ProgressKey()));
      else
        _progressService.SetDefault();
    }
  }
}