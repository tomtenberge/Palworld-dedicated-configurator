Public Class PalworldOptionSettings
    ' General Settings
    Public Property Difficulty As Object = Nothing
    Public Property DayTimeSpeedRate As Double = 1.0
    Public Property NightTimeSpeedRate As Double = 1.0
    Public Property ExpRate As Double = 1.0
    Public Property PalCaptureRate As Double = 1.0
    Public Property PalSpawnNumRate As Double = 1.0

    ' Player Settings
    Public Property PalDamageRateAttack As Double = 1.0
    Public Property PalDamageRateDefense As Double = 1.0
    Public Property PlayerDamageRateAttack As Double = 1.0
    Public Property PlayerDamageRateDefense As Double = 1.0
    Public Property PlayerStomachDecreaceRate As Double = 1.0
    Public Property PlayerStaminaDecreaceRate As Double = 1.0
    Public Property PlayerAutoHPRegeneRate As Double = 1.0
    Public Property PlayerAutoHpRegeneRateInSleep As Double = 1.0

    ' Pal Settings
    Public Property PalStomachDecreaceRate As Double = 1.0
    Public Property PalStaminaDecreaceRate As Double = 1.0
    Public Property PalAutoHPRegeneRate As Double = 1.0
    Public Property PalAutoHpRegeneRateInSleep As Double = 1.0

    ' Object and Collection Settings
    Public Property BuildObjectDamageRate As Double = 1.0
    Public Property BuildObjectDeteriorationDamageRate As Double = 1.0
    Public Property CollectionDropRate As Double = 1.0
    Public Property CollectionObjectHpRate As Double = 1.0
    Public Property CollectionObjectRespawnSpeedRate As Double = 1.0
    Public Property EnemyDropItemRate As Double = 1.0

    ' Death and Penalty Settings
    Public Property DeathPenalty As String = "All"
    Public Property bEnablePlayerToPlayerDamage As Boolean = False
    Public Property bEnableFriendlyFire As Boolean = False
    Public Property bEnableInvaderEnemy As Boolean = True
    Public Property bActiveUNKO As Boolean = False
    Public Property bEnableAimAssistPad As Boolean = True
    Public Property bEnableAimAssistKeyboard As Boolean = False

    ' Limits and Numbers
    Public Property DropItemMaxNum As Integer = 3000
    Public Property DropItemMaxNum_UNKO As Integer = 100
    Public Property BaseCampMaxNum As Integer = 128
    Public Property BaseCampWorkerMaxNum As Integer = 15
    Public Property DropItemAliveMaxHours As Double = 1.0
    Public Property bAutoResetGuildNoOnlinePlayers As Boolean = False
    Public Property AutoResetGuildTimeNoOnlinePlayers As Double = 72.0
    Public Property GuildPlayerMaxNum As Integer = 20
    Public Property PalEggDefaultHatchingTime As Double = 72.0
    Public Property WorkSpeedRate As Double = 1.0

    ' Multiplayer Settings
    Public Property bIsMultiplay As Boolean = False
    Public Property bIsPvP As Boolean = False
    Public Property bCanPickupOtherGuildDeathPenaltyDrop As Boolean = False
    Public Property bEnableNonLoginPenalty As Boolean = True
    Public Property bEnableFastTravel As Boolean = True
    Public Property bIsStartLocationSelectByMap As Boolean = True
    Public Property bExistPlayerAfterLogout As Boolean = False
    Public Property bEnableDefenseOtherGuildPlayer As Boolean = False
    Public Property CoopPlayerMaxNum As Integer = 4
    Public Property ServerPlayerMaxNum As Integer = 32

    ' Server Settings
    Public Property ServerName As String = "Default Palworld Server"
    Public Property ServerDescription As String = ""
    Public Property AdminPassword As String = ""
    Public Property ServerPassword As String = ""
    Public Property PublicPort As Integer = 8211
    Public Property PublicIP As String = ""
    Public Property RCONEnabled As Boolean = False
    Public Property RCONPort As Integer = 25575
    Public Property Region As String = ""
    Public Property bUseAuth As Boolean = True
    Public Property BanListURL As String = "https://api.palworldgame.com/api/banlist.txt"
End Class