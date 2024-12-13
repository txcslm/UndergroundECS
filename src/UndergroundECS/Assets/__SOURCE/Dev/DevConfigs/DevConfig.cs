namespace DevConfigs
{
  public class DevConfig
  {
    public const string CoroutineRunner = nameof(CoroutineRunner);
    public const string LoadingCurtain = nameof(LoadingCurtain);

    public const float ProjectileLifeTime = 2;

    public const int TargetOverlapColliders = 50;
    public const int EnemyAssistCallOverlapCount = 50;

    public const float RandomValuesPercentDelta = 15;
    public const float ProjectileRadiusChecker = 0.1f;
    public const float MinPointerDistance = 10f;

    public const float MinCompanionFollowDistance = .1f;
    public const float MaxCompanionFollowDistance = 6f;

    public const float DistanceToRoutePoint = 1;
    public const float MinMoveDirectionLength = 0.0f;
  }
}