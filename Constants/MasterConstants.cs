using Edelstein.Data.Msts;
using Edelstein.Data.Serialization;

using System.Diagnostics.CodeAnalysis;

namespace Edelstein.Data.Constants;

public static class MasterConstants
{
    public static int AdvBgmVolumeCoefficient { get; private set; }
    public static int AdvSeVolumeCoefficient { get; private set; }
    public static int AdvVoiceVolumeCoefficient { get; private set; }
    public static string AqoursStoryTrackingList { get; private set; } = String.Empty;
    public static int AreaEventPerArea { get; private set; }
    public static int AreaTalkBalloonIntervalMsec { get; private set; }
    public static int AreaTalkBalloonViewMsec { get; private set; }
    public static int AreaWorldIdBirthday { get; private set; }
    public static int AreaWorldIdDefault { get; private set; }
    public static int AutoTicketMasterItemId { get; private set; }
    public static int BannerMoveSecond { get; private set; }
    public static int BatteryCheckNum { get; private set; }
    public static int BeforeRecommendEmptyId { get; private set; }
    public static int CandyAdjustNumber { get; private set; }
    public static int CandyScoreBonusDenominator { get; private set; }
    public static int CandyScoreBonusNumerator { get; private set; }
    public static int CardEpisodeRewardGem { get; private set; }
    public static int CardSpecialEpisodeRewardGem { get; private set; }
    public static int CharacterFriendshipCenterBonus { get; private set; }
    public static int CharacterFriendshipFrontBonus { get; private set; }
    public static int CharacterFriendshipMax { get; private set; }
    public static int CharacterFriendshipRewardBase { get; private set; }
    public static int ComebackLoginBonusRequireDays { get; private set; }
    public static int CommonLotteryExchangeMasterItemId { get; private set; }
    public static int CountBadgeMax { get; private set; }
    public static int DailyFreeMusicChangeLimit { get; private set; }
    public static int DefaultLivePower { get; private set; }
    public static int DefaultMasterTitleId { get; private set; }
    public static int DefaultMaxOrnamentLevel { get; private set; }
    public static int DefaultRoomMasterAreaId { get; private set; }
    public static string DefaultUserComment { get; private set; } = String.Empty;
    public static string DefaultUserName { get; private set; } = String.Empty;
    public static int EventCoinAdjustNumber { get; private set; }
    public static int EventCoinScoreBonusDenominator { get; private set; }
    public static int EventCoinScoreBonusNumerator { get; private set; }
    public static int EventHomeworkClearBonus { get; private set; }
    public static int EventLivePointBoost { get; private set; }
    public static decimal EventPointAdjustNumber { get; private set; }
    public static int EventPointScoreBonusDenominator { get; private set; }
    public static int EventPointScoreBonusNumerator { get; private set; }
    public static int EventTopLive2dEventTalkPercent { get; private set; }
    public static int EvolveItemCountMax { get; private set; }
    public static int EvolveRare3MasterItemId { get; private set; }
    public static int EvolveRare3NeedItemCount { get; private set; }
    public static int EvolveRare4MasterItemId { get; private set; }
    public static int EvolveRare4NeedItemCount { get; private set; }
    public static int ExcessStamina { get; private set; }
    public static int ExchangeCardLotteryEffArtistMovieMasterId { get; private set; }
    public static int ExchangeCardLotteryEffExpectedMasterId { get; private set; }
    public static int ExchangeCardLotteryEffStepMovieMasterId { get; private set; }
    public static int GiftExpireDay { get; private set; }
    public static int HighScoreRateCoefficient { get; private set; }
    public static int HighScoreRateListMax { get; private set; }
    public static string InitialPurchase { get; private set; } = String.Empty;
    public static string LiellaStoryTrackingList { get; private set; } = String.Empty;
    public static int LimitStamina { get; private set; }
    public static int LiveContinueUseGem { get; private set; }
    public static int LiveErorrTime { get; private set; }
    public static decimal LivePowerZeroScoreCoefficient { get; private set; }
    public static string LivesceneSkillnameEllipsis { get; private set; } = String.Empty;
    public static int LivesceneSkillnameMaxLength { get; private set; }
    public static DateTimeOffset LocalP3ServiceEnd { get; private set; }
    public static DateTimeOffset LocalP4RefundStart { get; private set; }
    public static DateTimeOffset LocalP5RefundEnd { get; private set; }
    public static string LoginBonus { get; private set; } = String.Empty;
    public static int LotteryMultiTicket { get; private set; }
    public static int LotterySingleTicket { get; private set; }
    public static int MaxCardAmount { get; private set; }
    public static int MaxCoin { get; private set; }
    public static int MaxEventPoint { get; private set; }
    public static int MaxFriendPending { get; private set; }
    public static int MaxFriendRequest { get; private set; }
    public static int MaxFriendSearch { get; private set; }
    public static int MaxGem { get; private set; }
    public static int MaxGift { get; private set; }
    public static int MaxGiftHistory { get; private set; }
    public static int MaxItemAmount { get; private set; }
    public static int MaxLivePower { get; private set; }
    public static int MaxLotteryBoxDrawCount { get; private set; }
    public static int MaxMainAreaEvent { get; private set; }
    public static int MaxMainAreaEventPerArea { get; private set; }
    public static int MaxNewMainAreaEvent { get; private set; }
    public static int MaxNewOrnamentEvent { get; private set; }
    public static int MaxSeal { get; private set; }
    public static int MaxSkillLevel { get; private set; }
    public static int MaxStamina { get; private set; }
    public static int MinCardAmount { get; private set; }
    public static int MinCoin { get; private set; }
    public static int MinGem { get; private set; }
    public static int MinGift { get; private set; }
    public static int MinItemAmount { get; private set; }
    public static int MinMainAreaEventPerArea { get; private set; }
    public static int MinMusicLevelNumber { get; private set; }
    public static int MinNewMainAreaEvent { get; private set; }
    public static int MinNewOrnamentEvent { get; private set; }
    public static int MinSeal { get; private set; }
    public static int MinSkillLevel { get; private set; }
    public static int MinStamina { get; private set; }
    public static int MovieDeleteNum { get; private set; }
    public static int MovieExpiryDay { get; private set; }
    public static int MovieHistoryNum { get; private set; }
    public static int MultiCommentMaxNum { get; private set; }
    public static int MultiEventLiveGreatPerfectNotesMinRatio { get; private set; }
    public static int MultiLastConfirmTime { get; private set; }
    public static int MultiLevelSelectTime { get; private set; }
    public static int MultiLiveTimeOut { get; private set; }
    public static int MultiMusicSelectTime { get; private set; }
    public static int MultiPenaltyDefaultId { get; private set; }
    public static int MultiPenaltyMissRatio { get; private set; }
    public static int MultiPenaltyNoPlayMissRatio { get; private set; }
    public static int MultiPrivateRoomIdFormat { get; private set; }
    public static int MultiPrivateRoomMaxId { get; private set; }
    public static int MultiPrivateRoomMinId { get; private set; }
    public static int MultiPrivateRoomPass { get; private set; }
    public static int MultiPrivateRoomPassCount { get; private set; }
    public static string MultiRegion { get; private set; } = String.Empty;
    public static int MultiRoomMaxId { get; private set; }
    public static int MultiRoomMinId { get; private set; }
    public static string MuseStoryTrackingList { get; private set; } = String.Empty;
    public static int MusicChangePrice { get; private set; }
    public static string NigigasakiStoryTrackingList { get; private set; } = String.Empty;
    public static int OneMegaByteToByte { get; private set; }
    public static int PickAdjustNumber { get; private set; }
    public static int PickScoreBonusDenominator { get; private set; }
    public static int PickScoreBonusNumerator { get; private set; }
    public static List<int> PlayerRanksTrackingList { get; private set; } = [];
    public static int PresentBoxExpireNotifyHour { get; private set; }
    public static string Purchase { get; private set; } = String.Empty;
    public static string Rank005 { get; private set; } = String.Empty;
    public static string Rank010 { get; private set; } = String.Empty;
    public static string Rank030 { get; private set; } = String.Empty;
    public static string Rank050 { get; private set; } = String.Empty;
    public static string Rank100 { get; private set; } = String.Empty;
    public static string Rank200 { get; private set; } = String.Empty;
    public static string Rank300 { get; private set; } = String.Empty;
    public static bool RejectPurchaseFlag { get; private set; }
    public static decimal ScoreDeckPowerCoefficient { get; private set; }
    public static decimal ScoreLevelAdjustCoefficient { get; private set; }
    public static int ScoreLevelMinCoefficient { get; private set; }
    public static int ScoreTotalPowerCoefficient { get; private set; }
    public static int SerifHideTime { get; private set; }
    public static int SkillReinforceSameCardRatio { get; private set; }
    public static int SpiritAdjustNumber { get; private set; }
    public static int SpiritScoreBonusDenominator { get; private set; }
    public static int SpiritScoreBonusNumerator { get; private set; }
    public static DateTimeOffset SsAlignmentEndDatetime { get; private set; }
    public static string SsTheaterNotFound { get; private set; } = String.Empty;
    public static int StaminaRecoverTime { get; private set; }
    public static int StaminaRecoverValue { get; private set; }
    public static int StampOnePageNum { get; private set; }
    public static int StarAssistCardBonusCoefficient { get; private set; }
    public static int StarAssistCardCoefficient { get; private set; }
    public static int StarAssistSkillCoefficient1 { get; private set; }
    public static int StarAssistSkillCoefficient2 { get; private set; }
    public static int StarAssistSkillProbability { get; private set; }
    public static int StarBonusCoefficient { get; private set; }
    public static int StarEventBonusCoefficient { get; private set; }
    public static int StarEventBonusMaxDailyCount { get; private set; }
    public static string StoryclearAqours01 { get; private set; } = String.Empty;
    public static string StoryclearAqours02 { get; private set; } = String.Empty;
    public static string StoryclearAqours03 { get; private set; } = String.Empty;
    public static string StoryclearAqours04 { get; private set; } = String.Empty;
    public static string StoryclearAqours05 { get; private set; } = String.Empty;
    public static string StoryclearMs01 { get; private set; } = String.Empty;
    public static string StoryclearMs02 { get; private set; } = String.Empty;
    public static string StoryclearMs03 { get; private set; } = String.Empty;
    public static string StoryclearMs04 { get; private set; } = String.Empty;
    public static string StoryclearMs05 { get; private set; } = String.Empty;
    public static string StoryclearNiji01 { get; private set; } = String.Empty;
    public static string StoryclearNiji02 { get; private set; } = String.Empty;
    public static string StoryclearNiji03 { get; private set; } = String.Empty;
    public static string StoryclearNiji04 { get; private set; } = String.Empty;
    public static string StoryclearNiji05 { get; private set; } = String.Empty;
    public static int TalkUserExpBase { get; private set; }
    public static int TutorialCardReinforceMasterItemId { get; private set; }
    public static string TutorialComplete { get; private set; } = String.Empty;
    public static List<int> TutorialExcludeMember { get; private set; } = [];
    public static int TutorialGuestUserCardLevel { get; private set; }
    public static string TutorialGuestUserComment { get; private set; } = String.Empty;
    public static int TutorialGuestUserMasterCardId { get; private set; }
    public static string TutorialGuestUserName { get; private set; } = String.Empty;
    public static int TutorialGuestUserRank { get; private set; }
    public static int TutorialGuestUserTitleId { get; private set; }
    public static int TutorialMasterStoryPartId { get; private set; }
    public static int TutorialMasterTalkId { get; private set; }
    public static int TutorialMinLotteryId { get; private set; }
    public static int TutorialSpeechBubbleMission1 { get; private set; }
    public static int TutorialSpeechBubbleMission2 { get; private set; }
    public static int TutorialSpeechBubbleMission3 { get; private set; }
    public static string UsernameComplete { get; private set; } = String.Empty;

    private static Dictionary<string, string> _constantsDictionary = new();

    public static string? GetConstantOrDefault(string name) =>
        _constantsDictionary.GetValueOrDefault(name);

    public static bool TryGetConstant(string name, [NotNullWhen(true)] out string? value)
    {
        value = GetConstantOrDefault(name);
        return value != null;
    }

    /// <summary>Loads constants into statically-typed properties into <see cref="MasterConstants"/> class.</summary>
    /// <param name="constMsts">List of <see cref="ConstMst"/> from which to load values.</param>
    /// <param name="failedToReadConstantNames">List of all constant names that were not read successfully.</param>
    public static void Load(List<ConstMst> constMsts, out List<string> failedToReadConstantNames)
    {
        _constantsDictionary = constMsts.ToDictionary(x => x.Id, x => x.Value);

        failedToReadConstantNames = [];

        if (TryGetConstant("ADV_BGM_VOLUME_COEFFICIENT", out string? readAdvBgmVolumeCoefficient) &&
            Int32.TryParse(readAdvBgmVolumeCoefficient, out int intReadAdvBgmVolumeCoefficient))
            AdvBgmVolumeCoefficient = intReadAdvBgmVolumeCoefficient;
        else
            failedToReadConstantNames.Add("ADV_BGM_VOLUME_COEFFICIENT");

        if (TryGetConstant("ADV_SE_VOLUME_COEFFICIENT", out string? readAdvSeVolumeCoefficient) &&
            Int32.TryParse(readAdvSeVolumeCoefficient, out int intReadAdvSeVolumeCoefficient))
            AdvSeVolumeCoefficient = intReadAdvSeVolumeCoefficient;
        else
            failedToReadConstantNames.Add("ADV_SE_VOLUME_COEFFICIENT");

        if (TryGetConstant("ADV_VOICE_VOLUME_COEFFICIENT", out string? readAdvVoiceVolumeCoefficient) &&
            Int32.TryParse(readAdvVoiceVolumeCoefficient, out int intReadAdvVoiceVolumeCoefficient))
            AdvVoiceVolumeCoefficient = intReadAdvVoiceVolumeCoefficient;
        else
            failedToReadConstantNames.Add("ADV_VOICE_VOLUME_COEFFICIENT");

        if (TryGetConstant("AQOURS_STORY_TRACKING_LIST", out string? readAqoursStoryTrackingList))
            AqoursStoryTrackingList = readAqoursStoryTrackingList;
        else
            failedToReadConstantNames.Add("AQOURS_STORY_TRACKING_LIST");

        if (TryGetConstant("AREA_EVENT_PER_AREA", out string? readAreaEventPerArea) &&
            Int32.TryParse(readAreaEventPerArea, out int intReadAreaEventPerArea))
            AreaEventPerArea = intReadAreaEventPerArea;
        else
            failedToReadConstantNames.Add("AREA_EVENT_PER_AREA");

        if (TryGetConstant("AREA_TALK_BALLOON_INTERVAL_MSEC", out string? readAreaTalkBalloonIntervalMsec) &&
            Int32.TryParse(readAreaTalkBalloonIntervalMsec, out int intReadAreaTalkBalloonIntervalMsec))
            AreaTalkBalloonIntervalMsec = intReadAreaTalkBalloonIntervalMsec;
        else
            failedToReadConstantNames.Add("AREA_TALK_BALLOON_INTERVAL_MSEC");

        if (TryGetConstant("AREA_TALK_BALLOON_VIEW_MSEC", out string? readAreaTalkBalloonViewMsec) &&
            Int32.TryParse(readAreaTalkBalloonViewMsec, out int intReadAreaTalkBalloonViewMsec))
            AreaTalkBalloonViewMsec = intReadAreaTalkBalloonViewMsec;
        else
            failedToReadConstantNames.Add("AREA_TALK_BALLOON_VIEW_MSEC");

        if (TryGetConstant("AREA_WORLD_ID_BIRTHDAY", out string? readAreaWorldIdBirthday) &&
            Int32.TryParse(readAreaWorldIdBirthday, out int intReadAreaWorldIdBirthday))
            AreaWorldIdBirthday = intReadAreaWorldIdBirthday;
        else
            failedToReadConstantNames.Add("AREA_WORLD_ID_BIRTHDAY");

        if (TryGetConstant("AREA_WORLD_ID_DEFAULT", out string? readAreaWorldIdDefault) &&
            Int32.TryParse(readAreaWorldIdDefault, out int intReadAreaWorldIdDefault))
            AreaWorldIdDefault = intReadAreaWorldIdDefault;
        else
            failedToReadConstantNames.Add("AREA_WORLD_ID_DEFAULT");

        if (TryGetConstant("AUTO_TICKET_MASTER_ITEM_ID", out string? readAutoTicketMasterItemId) &&
            Int32.TryParse(readAutoTicketMasterItemId, out int intReadAutoTicketMasterItemId))
            AutoTicketMasterItemId = intReadAutoTicketMasterItemId;
        else
            failedToReadConstantNames.Add("AUTO_TICKET_MASTER_ITEM_ID");

        if (TryGetConstant("BANNER_MOVE_SECOND", out string? readBannerMoveSecond) &&
            Int32.TryParse(readBannerMoveSecond, out int intReadBannerMoveSecond))
            BannerMoveSecond = intReadBannerMoveSecond;
        else
            failedToReadConstantNames.Add("BANNER_MOVE_SECOND");

        if (TryGetConstant("BATTERY_CHECK_NUM", out string? readBatteryCheckNum) &&
            Int32.TryParse(readBatteryCheckNum, out int intReadBatteryCheckNum))
            BatteryCheckNum = intReadBatteryCheckNum;
        else
            failedToReadConstantNames.Add("BATTERY_CHECK_NUM");

        if (TryGetConstant("BEFORE_RECOMMEND_EMPTY_ID", out string? readBeforeRecommendEmptyId) &&
            Int32.TryParse(readBeforeRecommendEmptyId, out int intReadBeforeRecommendEmptyId))
            BeforeRecommendEmptyId = intReadBeforeRecommendEmptyId;
        else
            failedToReadConstantNames.Add("BEFORE_RECOMMEND_EMPTY_ID");

        if (TryGetConstant("CANDY_ADJUST_NUMBER", out string? readCandyAdjustNumber) &&
            Int32.TryParse(readCandyAdjustNumber, out int intReadCandyAdjustNumber))
            CandyAdjustNumber = intReadCandyAdjustNumber;
        else
            failedToReadConstantNames.Add("CANDY_ADJUST_NUMBER");

        if (TryGetConstant("CANDY_SCORE_BONUS_DENOMINATOR", out string? readCandyScoreBonusDenominator) &&
            Int32.TryParse(readCandyScoreBonusDenominator, out int intReadCandyScoreBonusDenominator))
            CandyScoreBonusDenominator = intReadCandyScoreBonusDenominator;
        else
            failedToReadConstantNames.Add("CANDY_SCORE_BONUS_DENOMINATOR");

        if (TryGetConstant("CANDY_SCORE_BONUS_NUMERATOR", out string? readCandyScoreBonusNumerator) &&
            Int32.TryParse(readCandyScoreBonusNumerator, out int intReadCandyScoreBonusNumerator))
            CandyScoreBonusNumerator = intReadCandyScoreBonusNumerator;
        else
            failedToReadConstantNames.Add("CANDY_SCORE_BONUS_NUMERATOR");

        if (TryGetConstant("CARD_EPISODE_REWARD_GEM", out string? readCardEpisodeRewardGem) &&
            Int32.TryParse(readCardEpisodeRewardGem, out int intReadCardEpisodeRewardGem))
            CardEpisodeRewardGem = intReadCardEpisodeRewardGem;
        else
            failedToReadConstantNames.Add("CARD_EPISODE_REWARD_GEM");

        if (TryGetConstant("CARD_SPECIAL_EPISODE_REWARD_GEM", out string? readCardSpecialEpisodeRewardGem) &&
            Int32.TryParse(readCardSpecialEpisodeRewardGem, out int intReadCardSpecialEpisodeRewardGem))
            CardSpecialEpisodeRewardGem = intReadCardSpecialEpisodeRewardGem;
        else
            failedToReadConstantNames.Add("CARD_SPECIAL_EPISODE_REWARD_GEM");

        if (TryGetConstant("CHARACTER_FRIENDSHIP_CENTER_BONUS", out string? readCharacterFriendshipCenterBonus) &&
            Int32.TryParse(readCharacterFriendshipCenterBonus, out int intReadCharacterFriendshipCenterBonus))
            CharacterFriendshipCenterBonus = intReadCharacterFriendshipCenterBonus;
        else
            failedToReadConstantNames.Add("CHARACTER_FRIENDSHIP_CENTER_BONUS");

        if (TryGetConstant("CHARACTER_FRIENDSHIP_FRONT_BONUS", out string? readCharacterFriendshipFrontBonus) &&
            Int32.TryParse(readCharacterFriendshipFrontBonus, out int intReadCharacterFriendshipFrontBonus))
            CharacterFriendshipFrontBonus = intReadCharacterFriendshipFrontBonus;
        else
            failedToReadConstantNames.Add("CHARACTER_FRIENDSHIP_FRONT_BONUS");

        if (TryGetConstant("CHARACTER_FRIENDSHIP_MAX", out string? readCharacterFriendshipMax) &&
            Int32.TryParse(readCharacterFriendshipMax, out int intReadCharacterFriendshipMax))
            CharacterFriendshipMax = intReadCharacterFriendshipMax;
        else
            failedToReadConstantNames.Add("CHARACTER_FRIENDSHIP_MAX");

        if (TryGetConstant("CHARACTER_FRIENDSHIP_REWARD_BASE", out string? readCharacterFriendshipRewardBase) &&
            Int32.TryParse(readCharacterFriendshipRewardBase, out int intReadCharacterFriendshipRewardBase))
            CharacterFriendshipRewardBase = intReadCharacterFriendshipRewardBase;
        else
            failedToReadConstantNames.Add("CHARACTER_FRIENDSHIP_REWARD_BASE");

        if (TryGetConstant("COMEBACK_LOGIN_BONUS_REQUIRE_DAYS", out string? readComebackLoginBonusRequireDays) &&
            Int32.TryParse(readComebackLoginBonusRequireDays, out int intReadComebackLoginBonusRequireDays))
            ComebackLoginBonusRequireDays = intReadComebackLoginBonusRequireDays;
        else
            failedToReadConstantNames.Add("COMEBACK_LOGIN_BONUS_REQUIRE_DAYS");

        if (TryGetConstant("COMMON_LOTTERY_EXCHANGE_MASTER_ITEM_ID", out string? readCommonLotteryExchangeMasterItemId) &&
            Int32.TryParse(readCommonLotteryExchangeMasterItemId, out int intReadCommonLotteryExchangeMasterItemId))
            CommonLotteryExchangeMasterItemId = intReadCommonLotteryExchangeMasterItemId;
        else
            failedToReadConstantNames.Add("COMMON_LOTTERY_EXCHANGE_MASTER_ITEM_ID");

        if (TryGetConstant("COUNT_BADGE_MAX", out string? readCountBadgeMax) &&
            Int32.TryParse(readCountBadgeMax, out int intReadCountBadgeMax))
            CountBadgeMax = intReadCountBadgeMax;
        else
            failedToReadConstantNames.Add("COUNT_BADGE_MAX");

        if (TryGetConstant("DAILY_FREE_MUSIC_CHANGE_LIMIT", out string? readDailyFreeMusicChangeLimit) &&
            Int32.TryParse(readDailyFreeMusicChangeLimit, out int intReadDailyFreeMusicChangeLimit))
            DailyFreeMusicChangeLimit = intReadDailyFreeMusicChangeLimit;
        else
            failedToReadConstantNames.Add("DAILY_FREE_MUSIC_CHANGE_LIMIT");

        if (TryGetConstant("DEFAULT_LIVE_POWER", out string? readDefaultLivePower) &&
            Int32.TryParse(readDefaultLivePower, out int intReadDefaultLivePower))
            DefaultLivePower = intReadDefaultLivePower;
        else
            failedToReadConstantNames.Add("DEFAULT_LIVE_POWER");

        if (TryGetConstant("DEFAULT_MASTER_TITLE_ID", out string? readDefaultMasterTitleId) &&
            Int32.TryParse(readDefaultMasterTitleId, out int intReadDefaultMasterTitleId))
            DefaultMasterTitleId = intReadDefaultMasterTitleId;
        else
            failedToReadConstantNames.Add("DEFAULT_MASTER_TITLE_ID");

        if (TryGetConstant("DEFAULT_MAX_ORNAMENT_LEVEL", out string? readDefaultMaxOrnamentLevel) &&
            Int32.TryParse(readDefaultMaxOrnamentLevel, out int intReadDefaultMaxOrnamentLevel))
            DefaultMaxOrnamentLevel = intReadDefaultMaxOrnamentLevel;
        else
            failedToReadConstantNames.Add("DEFAULT_MAX_ORNAMENT_LEVEL");

        if (TryGetConstant("DEFAULT_ROOM_MASTER_AREA_ID", out string? readDefaultRoomMasterAreaId) &&
            Int32.TryParse(readDefaultRoomMasterAreaId, out int intReadDefaultRoomMasterAreaId))
            DefaultRoomMasterAreaId = intReadDefaultRoomMasterAreaId;
        else
            failedToReadConstantNames.Add("DEFAULT_ROOM_MASTER_AREA_ID");

        if (TryGetConstant("DEFAULT_USER_COMMENT", out string? readDefaultUserComment))
            DefaultUserComment = readDefaultUserComment;
        else
            failedToReadConstantNames.Add("DEFAULT_USER_COMMENT");

        if (TryGetConstant("DEFAULT_USER_NAME", out string? readDefaultUserName))
            DefaultUserName = readDefaultUserName;
        else
            failedToReadConstantNames.Add("DEFAULT_USER_NAME");

        if (TryGetConstant("EVENT_COIN_ADJUST_NUMBER", out string? readEventCoinAdjustNumber) &&
            Int32.TryParse(readEventCoinAdjustNumber, out int intReadEventCoinAdjustNumber))
            EventCoinAdjustNumber = intReadEventCoinAdjustNumber;
        else
            failedToReadConstantNames.Add("EVENT_COIN_ADJUST_NUMBER");

        if (TryGetConstant("EVENT_COIN_SCORE_BONUS_DENOMINATOR", out string? readEventCoinScoreBonusDenominator) &&
            Int32.TryParse(readEventCoinScoreBonusDenominator, out int intReadEventCoinScoreBonusDenominator))
            EventCoinScoreBonusDenominator = intReadEventCoinScoreBonusDenominator;
        else
            failedToReadConstantNames.Add("EVENT_COIN_SCORE_BONUS_DENOMINATOR");

        if (TryGetConstant("EVENT_COIN_SCORE_BONUS_NUMERATOR", out string? readEventCoinScoreBonusNumerator) &&
            Int32.TryParse(readEventCoinScoreBonusNumerator, out int intReadEventCoinScoreBonusNumerator))
            EventCoinScoreBonusNumerator = intReadEventCoinScoreBonusNumerator;
        else
            failedToReadConstantNames.Add("EVENT_COIN_SCORE_BONUS_NUMERATOR");

        if (TryGetConstant("EVENT_HOMEWORK_CLEAR_BONUS", out string? readEventHomeworkClearBonus) &&
            Int32.TryParse(readEventHomeworkClearBonus, out int intReadEventHomeworkClearBonus))
            EventHomeworkClearBonus = intReadEventHomeworkClearBonus;
        else
            failedToReadConstantNames.Add("EVENT_HOMEWORK_CLEAR_BONUS");

        if (TryGetConstant("EVENT_LIVE_POINT_BOOST", out string? readEventLivePointBoost) &&
            Int32.TryParse(readEventLivePointBoost, out int intReadEventLivePointBoost))
            EventLivePointBoost = intReadEventLivePointBoost;
        else
            failedToReadConstantNames.Add("EVENT_LIVE_POINT_BOOST");

        if (TryGetConstant("EVENT_POINT_ADJUST_NUMBER", out string? readEventPointAdjustNumber) &&
            Decimal.TryParse(readEventPointAdjustNumber, out decimal decReadEventPointAdjustNumber))
            EventPointAdjustNumber = decReadEventPointAdjustNumber;
        else
            failedToReadConstantNames.Add("EVENT_POINT_ADJUST_NUMBER");

        if (TryGetConstant("EVENT_POINT_SCORE_BONUS_DENOMINATOR", out string? readEventPointScoreBonusDenominator) &&
            Int32.TryParse(readEventPointScoreBonusDenominator, out int intReadEventPointScoreBonusDenominator))
            EventPointScoreBonusDenominator = intReadEventPointScoreBonusDenominator;
        else
            failedToReadConstantNames.Add("EVENT_POINT_SCORE_BONUS_DENOMINATOR");

        if (TryGetConstant("EVENT_POINT_SCORE_BONUS_NUMERATOR", out string? readEventPointScoreBonusNumerator) &&
            Int32.TryParse(readEventPointScoreBonusNumerator, out int intReadEventPointScoreBonusNumerator))
            EventPointScoreBonusNumerator = intReadEventPointScoreBonusNumerator;
        else
            failedToReadConstantNames.Add("EVENT_POINT_SCORE_BONUS_NUMERATOR");

        if (TryGetConstant("EVENT_TOP_LIVE2D_EVENT_TALK_PERCENT", out string? readEventTopLive2dEventTalkPercent) &&
            Int32.TryParse(readEventTopLive2dEventTalkPercent, out int intReadEventTopLive2dEventTalkPercent))
            EventTopLive2dEventTalkPercent = intReadEventTopLive2dEventTalkPercent;
        else
            failedToReadConstantNames.Add("EVENT_TOP_LIVE2D_EVENT_TALK_PERCENT");

        if (TryGetConstant("EVOLVE_ITEM_COUNT_MAX", out string? readEvolveItemCountMax) &&
            Int32.TryParse(readEvolveItemCountMax, out int intReadEvolveItemCountMax))
            EvolveItemCountMax = intReadEvolveItemCountMax;
        else
            failedToReadConstantNames.Add("EVOLVE_ITEM_COUNT_MAX");

        if (TryGetConstant("EVOLVE_RARE3_MASTER_ITEM_ID", out string? readEvolveRare3MasterItemId) &&
            Int32.TryParse(readEvolveRare3MasterItemId, out int intReadEvolveRare3MasterItemId))
            EvolveRare3MasterItemId = intReadEvolveRare3MasterItemId;
        else
            failedToReadConstantNames.Add("EVOLVE_RARE3_MASTER_ITEM_ID");

        if (TryGetConstant("EVOLVE_RARE3_NEED_ITEM_COUNT", out string? readEvolveRare3NeedItemCount) &&
            Int32.TryParse(readEvolveRare3NeedItemCount, out int intReadEvolveRare3NeedItemCount))
            EvolveRare3NeedItemCount = intReadEvolveRare3NeedItemCount;
        else
            failedToReadConstantNames.Add("EVOLVE_RARE3_NEED_ITEM_COUNT");

        if (TryGetConstant("EVOLVE_RARE4_MASTER_ITEM_ID", out string? readEvolveRare4MasterItemId) &&
            Int32.TryParse(readEvolveRare4MasterItemId, out int intReadEvolveRare4MasterItemId))
            EvolveRare4MasterItemId = intReadEvolveRare4MasterItemId;
        else
            failedToReadConstantNames.Add("EVOLVE_RARE4_MASTER_ITEM_ID");

        if (TryGetConstant("EVOLVE_RARE4_NEED_ITEM_COUNT", out string? readEvolveRare4NeedItemCount) &&
            Int32.TryParse(readEvolveRare4NeedItemCount, out int intReadEvolveRare4NeedItemCount))
            EvolveRare4NeedItemCount = intReadEvolveRare4NeedItemCount;
        else
            failedToReadConstantNames.Add("EVOLVE_RARE4_NEED_ITEM_COUNT");

        if (TryGetConstant("EXCESS_STAMINA", out string? readExcessStamina) &&
            Int32.TryParse(readExcessStamina, out int intReadExcessStamina))
            ExcessStamina = intReadExcessStamina;
        else
            failedToReadConstantNames.Add("EXCESS_STAMINA");

        if (TryGetConstant("EXCHANGE_CARD_LOTTERY_EFF_ARTIST_MOVIE_MASTER_ID", out string? readExchangeCardLotteryEffArtistMovieMasterId) &&
            Int32.TryParse(readExchangeCardLotteryEffArtistMovieMasterId, out int intReadExchangeCardLotteryEffArtistMovieMasterId))
            ExchangeCardLotteryEffArtistMovieMasterId = intReadExchangeCardLotteryEffArtistMovieMasterId;
        else
            failedToReadConstantNames.Add("EXCHANGE_CARD_LOTTERY_EFF_ARTIST_MOVIE_MASTER_ID");

        if (TryGetConstant("EXCHANGE_CARD_LOTTERY_EFF_EXPECTED_MASTER_ID", out string? readExchangeCardLotteryEffExpectedMasterId) &&
            Int32.TryParse(readExchangeCardLotteryEffExpectedMasterId, out int intReadExchangeCardLotteryEffExpectedMasterId))
            ExchangeCardLotteryEffExpectedMasterId = intReadExchangeCardLotteryEffExpectedMasterId;
        else
            failedToReadConstantNames.Add("EXCHANGE_CARD_LOTTERY_EFF_EXPECTED_MASTER_ID");

        if (TryGetConstant("EXCHANGE_CARD_LOTTERY_EFF_STEP_MOVIE_MASTER_ID", out string? readExchangeCardLotteryEffStepMovieMasterId) &&
            Int32.TryParse(readExchangeCardLotteryEffStepMovieMasterId, out int intReadExchangeCardLotteryEffStepMovieMasterId))
            ExchangeCardLotteryEffStepMovieMasterId = intReadExchangeCardLotteryEffStepMovieMasterId;
        else
            failedToReadConstantNames.Add("EXCHANGE_CARD_LOTTERY_EFF_STEP_MOVIE_MASTER_ID");

        if (TryGetConstant("GIFT_EXPIRE_DAY", out string? readGiftExpireDay) &&
            Int32.TryParse(readGiftExpireDay, out int intReadGiftExpireDay))
            GiftExpireDay = intReadGiftExpireDay;
        else
            failedToReadConstantNames.Add("GIFT_EXPIRE_DAY");

        if (TryGetConstant("HIGH_SCORE_RATE_COEFFICIENT", out string? readHighScoreRateCoefficient) &&
            Int32.TryParse(readHighScoreRateCoefficient, out int intReadHighScoreRateCoefficient))
            HighScoreRateCoefficient = intReadHighScoreRateCoefficient;
        else
            failedToReadConstantNames.Add("HIGH_SCORE_RATE_COEFFICIENT");

        if (TryGetConstant("HIGH_SCORE_RATE_LIST_MAX", out string? readHighScoreRateListMax) &&
            Int32.TryParse(readHighScoreRateListMax, out int intReadHighScoreRateListMax))
            HighScoreRateListMax = intReadHighScoreRateListMax;
        else
            failedToReadConstantNames.Add("HIGH_SCORE_RATE_LIST_MAX");

        if (TryGetConstant("INITIAL_PURCHASE", out string? readInitialPurchase))
            InitialPurchase = readInitialPurchase;
        else
            failedToReadConstantNames.Add("INITIAL_PURCHASE");

        if (TryGetConstant("LIELLA_STORY_TRACKING_LIST", out string? readLiellaStoryTrackingList))
            LiellaStoryTrackingList = readLiellaStoryTrackingList;
        else
            failedToReadConstantNames.Add("LIELLA_STORY_TRACKING_LIST");

        if (TryGetConstant("LIMIT_STAMINA", out string? readLimitStamina) && Int32.TryParse(readLimitStamina, out int intReadLimitStamina))
            LimitStamina = intReadLimitStamina;
        else
            failedToReadConstantNames.Add("LIMIT_STAMINA");

        if (TryGetConstant("LIVE_CONTINUE_USE_GEM", out string? readLiveContinueUseGem) &&
            Int32.TryParse(readLiveContinueUseGem, out int intReadLiveContinueUseGem))
            LiveContinueUseGem = intReadLiveContinueUseGem;
        else
            failedToReadConstantNames.Add("LIVE_CONTINUE_USE_GEM");

        if (TryGetConstant("LIVE_ERORR_TIME", out string? readLiveErorrTime) &&
            Int32.TryParse(readLiveErorrTime, out int intReadLiveErorrTime))
            LiveErorrTime = intReadLiveErorrTime;
        else
            failedToReadConstantNames.Add("LIVE_ERORR_TIME");

        if (TryGetConstant("LIVE_POWER_ZERO_SCORE_COEFFICIENT", out string? readLivePowerZeroScoreCoefficient) &&
            Decimal.TryParse(readLivePowerZeroScoreCoefficient, out decimal decReadLivePowerZeroScoreCoefficient))
            LivePowerZeroScoreCoefficient = decReadLivePowerZeroScoreCoefficient;
        else
            failedToReadConstantNames.Add("LIVE_POWER_ZERO_SCORE_COEFFICIENT");

        if (TryGetConstant("LIVESCENE_SKILLNAME_ELLIPSIS", out string? readLivesceneSkillnameEllipsis))
            LivesceneSkillnameEllipsis = readLivesceneSkillnameEllipsis;
        else
            failedToReadConstantNames.Add("LIVESCENE_SKILLNAME_ELLIPSIS");

        if (TryGetConstant("LIVESCENE_SKILLNAME_MAX_LENGTH", out string? readLivesceneSkillnameMaxLength) &&
            Int32.TryParse(readLivesceneSkillnameMaxLength, out int intReadLivesceneSkillnameMaxLength))
            LivesceneSkillnameMaxLength = intReadLivesceneSkillnameMaxLength;
        else
            failedToReadConstantNames.Add("LIVESCENE_SKILLNAME_MAX_LENGTH");

        if (TryGetConstant("LOCAL_P3_SERVICE_END", out string? readLocalP3ServiceEnd) &&
            DateTimeOffset.TryParse(readLocalP3ServiceEnd, out DateTimeOffset dtoReadLocalP3ServiceEnd))
            LocalP3ServiceEnd = dtoReadLocalP3ServiceEnd;
        else
            failedToReadConstantNames.Add("LOCAL_P3_SERVICE_END");

        if (TryGetConstant("LOCAL_P4_REFUND_START", out string? readLocalP4RefundStart) &&
            DateTimeOffset.TryParse(readLocalP4RefundStart, out DateTimeOffset dtoReadLocalP4RefundStart))
            LocalP4RefundStart = dtoReadLocalP4RefundStart;
        else
            failedToReadConstantNames.Add("LOCAL_P4_REFUND_START");

        if (TryGetConstant("LOCAL_P5_REFUND_END", out string? readLocalP5RefundEnd) &&
            DateTimeOffset.TryParse(readLocalP5RefundEnd, out DateTimeOffset dtoReadLocalP5RefundEnd))
            LocalP5RefundEnd = dtoReadLocalP5RefundEnd;
        else
            failedToReadConstantNames.Add("LOCAL_P5_REFUND_END");

        if (TryGetConstant("LOGIN_BONUS", out string? readLoginBonus))
            LoginBonus = readLoginBonus;
        else
            failedToReadConstantNames.Add("LOGIN_BONUS");

        if (TryGetConstant("LOTTERY_MULTI_TICKET", out string? readLotteryMultiTicket) &&
            Int32.TryParse(readLotteryMultiTicket, out int intReadLotteryMultiTicket))
            LotteryMultiTicket = intReadLotteryMultiTicket;
        else
            failedToReadConstantNames.Add("LOTTERY_MULTI_TICKET");

        if (TryGetConstant("LOTTERY_SINGLE_TICKET", out string? readLotterySingleTicket) &&
            Int32.TryParse(readLotterySingleTicket, out int intReadLotterySingleTicket))
            LotterySingleTicket = intReadLotterySingleTicket;
        else
            failedToReadConstantNames.Add("LOTTERY_SINGLE_TICKET");

        if (TryGetConstant("MAX_CARD_AMOUNT", out string? readMaxCardAmount) &&
            Int32.TryParse(readMaxCardAmount, out int intReadMaxCardAmount))
            MaxCardAmount = intReadMaxCardAmount;
        else
            failedToReadConstantNames.Add("MAX_CARD_AMOUNT");

        if (TryGetConstant("MAX_COIN", out string? readMaxCoin) && Int32.TryParse(readMaxCoin, out int intReadMaxCoin))
            MaxCoin = intReadMaxCoin;
        else
            failedToReadConstantNames.Add("MAX_COIN");

        if (TryGetConstant("MAX_EVENT_POINT", out string? readMaxEventPoint) &&
            Int32.TryParse(readMaxEventPoint, out int intReadMaxEventPoint))
            MaxEventPoint = intReadMaxEventPoint;
        else
            failedToReadConstantNames.Add("MAX_EVENT_POINT");

        if (TryGetConstant("MAX_FRIEND_PENDING", out string? readMaxFriendPending) &&
            Int32.TryParse(readMaxFriendPending, out int intReadMaxFriendPending))
            MaxFriendPending = intReadMaxFriendPending;
        else
            failedToReadConstantNames.Add("MAX_FRIEND_PENDING");

        if (TryGetConstant("MAX_FRIEND_REQUEST", out string? readMaxFriendRequest) &&
            Int32.TryParse(readMaxFriendRequest, out int intReadMaxFriendRequest))
            MaxFriendRequest = intReadMaxFriendRequest;
        else
            failedToReadConstantNames.Add("MAX_FRIEND_REQUEST");

        if (TryGetConstant("MAX_FRIEND_SEARCH", out string? readMaxFriendSearch) &&
            Int32.TryParse(readMaxFriendSearch, out int intReadMaxFriendSearch))
            MaxFriendSearch = intReadMaxFriendSearch;
        else
            failedToReadConstantNames.Add("MAX_FRIEND_SEARCH");

        if (TryGetConstant("MAX_GEM", out string? readMaxGem) && Int32.TryParse(readMaxGem, out int intReadMaxGem))
            MaxGem = intReadMaxGem;
        else
            failedToReadConstantNames.Add("MAX_GEM");

        if (TryGetConstant("MAX_GIFT", out string? readMaxGift) && Int32.TryParse(readMaxGift, out int intReadMaxGift))
            MaxGift = intReadMaxGift;
        else
            failedToReadConstantNames.Add("MAX_GIFT");

        if (TryGetConstant("MAX_GIFT_HISTORY", out string? readMaxGiftHistory) &&
            Int32.TryParse(readMaxGiftHistory, out int intReadMaxGiftHistory))
            MaxGiftHistory = intReadMaxGiftHistory;
        else
            failedToReadConstantNames.Add("MAX_GIFT_HISTORY");

        if (TryGetConstant("MAX_ITEM_AMOUNT", out string? readMaxItemAmount) &&
            Int32.TryParse(readMaxItemAmount, out int intReadMaxItemAmount))
            MaxItemAmount = intReadMaxItemAmount;
        else
            failedToReadConstantNames.Add("MAX_ITEM_AMOUNT");

        if (TryGetConstant("MAX_LIVE_POWER", out string? readMaxLivePower) && Int32.TryParse(readMaxLivePower, out int intReadMaxLivePower))
            MaxLivePower = intReadMaxLivePower;
        else
            failedToReadConstantNames.Add("MAX_LIVE_POWER");

        if (TryGetConstant("MAX_LOTTERY_BOX_DRAW_COUNT", out string? readMaxLotteryBoxDrawCount) &&
            Int32.TryParse(readMaxLotteryBoxDrawCount, out int intReadMaxLotteryBoxDrawCount))
            MaxLotteryBoxDrawCount = intReadMaxLotteryBoxDrawCount;
        else
            failedToReadConstantNames.Add("MAX_LOTTERY_BOX_DRAW_COUNT");

        if (TryGetConstant("MAX_MAIN_AREA_EVENT", out string? readMaxMainAreaEvent) &&
            Int32.TryParse(readMaxMainAreaEvent, out int intReadMaxMainAreaEvent))
            MaxMainAreaEvent = intReadMaxMainAreaEvent;
        else
            failedToReadConstantNames.Add("MAX_MAIN_AREA_EVENT");

        if (TryGetConstant("MAX_MAIN_AREA_EVENT_PER_AREA", out string? readMaxMainAreaEventPerArea) &&
            Int32.TryParse(readMaxMainAreaEventPerArea, out int intReadMaxMainAreaEventPerArea))
            MaxMainAreaEventPerArea = intReadMaxMainAreaEventPerArea;
        else
            failedToReadConstantNames.Add("MAX_MAIN_AREA_EVENT_PER_AREA");

        if (TryGetConstant("MAX_NEW_MAIN_AREA_EVENT", out string? readMaxNewMainAreaEvent) &&
            Int32.TryParse(readMaxNewMainAreaEvent, out int intReadMaxNewMainAreaEvent))
            MaxNewMainAreaEvent = intReadMaxNewMainAreaEvent;
        else
            failedToReadConstantNames.Add("MAX_NEW_MAIN_AREA_EVENT");

        if (TryGetConstant("MAX_NEW_ORNAMENT_EVENT", out string? readMaxNewOrnamentEvent) &&
            Int32.TryParse(readMaxNewOrnamentEvent, out int intReadMaxNewOrnamentEvent))
            MaxNewOrnamentEvent = intReadMaxNewOrnamentEvent;
        else
            failedToReadConstantNames.Add("MAX_NEW_ORNAMENT_EVENT");

        if (TryGetConstant("MAX_SEAL", out string? readMaxSeal) && Int32.TryParse(readMaxSeal, out int intReadMaxSeal))
            MaxSeal = intReadMaxSeal;
        else
            failedToReadConstantNames.Add("MAX_SEAL");

        if (TryGetConstant("MAX_SKILL_LEVEL", out string? readMaxSkillLevel) &&
            Int32.TryParse(readMaxSkillLevel, out int intReadMaxSkillLevel))
            MaxSkillLevel = intReadMaxSkillLevel;
        else
            failedToReadConstantNames.Add("MAX_SKILL_LEVEL");

        if (TryGetConstant("MAX_STAMINA", out string? readMaxStamina) && Int32.TryParse(readMaxStamina, out int intReadMaxStamina))
            MaxStamina = intReadMaxStamina;
        else
            failedToReadConstantNames.Add("MAX_STAMINA");

        if (TryGetConstant("MIN_CARD_AMOUNT", out string? readMinCardAmount) &&
            Int32.TryParse(readMinCardAmount, out int intReadMinCardAmount))
            MinCardAmount = intReadMinCardAmount;
        else
            failedToReadConstantNames.Add("MIN_CARD_AMOUNT");

        if (TryGetConstant("MIN_COIN", out string? readMinCoin) && Int32.TryParse(readMinCoin, out int intReadMinCoin))
            MinCoin = intReadMinCoin;
        else
            failedToReadConstantNames.Add("MIN_COIN");

        if (TryGetConstant("MIN_GEM", out string? readMinGem) && Int32.TryParse(readMinGem, out int intReadMinGem))
            MinGem = intReadMinGem;
        else
            failedToReadConstantNames.Add("MIN_GEM");

        if (TryGetConstant("MIN_GIFT", out string? readMinGift) && Int32.TryParse(readMinGift, out int intReadMinGift))
            MinGift = intReadMinGift;
        else
            failedToReadConstantNames.Add("MIN_GIFT");

        if (TryGetConstant("MIN_ITEM_AMOUNT", out string? readMinItemAmount) &&
            Int32.TryParse(readMinItemAmount, out int intReadMinItemAmount))
            MinItemAmount = intReadMinItemAmount;
        else
            failedToReadConstantNames.Add("MIN_ITEM_AMOUNT");

        if (TryGetConstant("MIN_MAIN_AREA_EVENT_PER_AREA", out string? readMinMainAreaEventPerArea) &&
            Int32.TryParse(readMinMainAreaEventPerArea, out int intReadMinMainAreaEventPerArea))
            MinMainAreaEventPerArea = intReadMinMainAreaEventPerArea;
        else
            failedToReadConstantNames.Add("MIN_MAIN_AREA_EVENT_PER_AREA");

        if (TryGetConstant("MIN_MUSIC_LEVEL_NUMBER", out string? readMinMusicLevelNumber) &&
            Int32.TryParse(readMinMusicLevelNumber, out int intReadMinMusicLevelNumber))
            MinMusicLevelNumber = intReadMinMusicLevelNumber;
        else
            failedToReadConstantNames.Add("MIN_MUSIC_LEVEL_NUMBER");

        if (TryGetConstant("MIN_NEW_MAIN_AREA_EVENT", out string? readMinNewMainAreaEvent) &&
            Int32.TryParse(readMinNewMainAreaEvent, out int intReadMinNewMainAreaEvent))
            MinNewMainAreaEvent = intReadMinNewMainAreaEvent;
        else
            failedToReadConstantNames.Add("MIN_NEW_MAIN_AREA_EVENT");

        if (TryGetConstant("MIN_NEW_ORNAMENT_EVENT", out string? readMinNewOrnamentEvent) &&
            Int32.TryParse(readMinNewOrnamentEvent, out int intReadMinNewOrnamentEvent))
            MinNewOrnamentEvent = intReadMinNewOrnamentEvent;
        else
            failedToReadConstantNames.Add("MIN_NEW_ORNAMENT_EVENT");

        if (TryGetConstant("MIN_SEAL", out string? readMinSeal) && Int32.TryParse(readMinSeal, out int intReadMinSeal))
            MinSeal = intReadMinSeal;
        else
            failedToReadConstantNames.Add("MIN_SEAL");

        if (TryGetConstant("MIN_SKILL_LEVEL", out string? readMinSkillLevel) &&
            Int32.TryParse(readMinSkillLevel, out int intReadMinSkillLevel))
            MinSkillLevel = intReadMinSkillLevel;
        else
            failedToReadConstantNames.Add("MIN_SKILL_LEVEL");

        if (TryGetConstant("MIN_STAMINA", out string? readMinStamina) && Int32.TryParse(readMinStamina, out int intReadMinStamina))
            MinStamina = intReadMinStamina;
        else
            failedToReadConstantNames.Add("MIN_STAMINA");

        if (TryGetConstant("MOVIE_DELETE_NUM", out string? readMovieDeleteNum) &&
            Int32.TryParse(readMovieDeleteNum, out int intReadMovieDeleteNum))
            MovieDeleteNum = intReadMovieDeleteNum;
        else
            failedToReadConstantNames.Add("MOVIE_DELETE_NUM");

        if (TryGetConstant("MOVIE_EXPIRY_DAY", out string? readMovieExpiryDay) &&
            Int32.TryParse(readMovieExpiryDay, out int intReadMovieExpiryDay))
            MovieExpiryDay = intReadMovieExpiryDay;
        else
            failedToReadConstantNames.Add("MOVIE_EXPIRY_DAY");

        if (TryGetConstant("MOVIE_HISTORY_NUM", out string? readMovieHistoryNum) &&
            Int32.TryParse(readMovieHistoryNum, out int intReadMovieHistoryNum))
            MovieHistoryNum = intReadMovieHistoryNum;
        else
            failedToReadConstantNames.Add("MOVIE_HISTORY_NUM");

        if (TryGetConstant("MULTI_COMMENT_MAX_NUM", out string? readMultiCommentMaxNum) &&
            Int32.TryParse(readMultiCommentMaxNum, out int intReadMultiCommentMaxNum))
            MultiCommentMaxNum = intReadMultiCommentMaxNum;
        else
            failedToReadConstantNames.Add("MULTI_COMMENT_MAX_NUM");

        if (TryGetConstant("MULTI_EVENT_LIVE_GREAT_PERFECT_NOTES_MIN_RATIO", out string? readMultiEventLiveGreatPerfectNotesMinRatio) &&
            Int32.TryParse(readMultiEventLiveGreatPerfectNotesMinRatio, out int intReadMultiEventLiveGreatPerfectNotesMinRatio))
            MultiEventLiveGreatPerfectNotesMinRatio = intReadMultiEventLiveGreatPerfectNotesMinRatio;
        else
            failedToReadConstantNames.Add("MULTI_EVENT_LIVE_GREAT_PERFECT_NOTES_MIN_RATIO");

        if (TryGetConstant("MULTI_LAST_CONFIRM_TIME", out string? readMultiLastConfirmTime) &&
            Int32.TryParse(readMultiLastConfirmTime, out int intReadMultiLastConfirmTime))
            MultiLastConfirmTime = intReadMultiLastConfirmTime;
        else
            failedToReadConstantNames.Add("MULTI_LAST_CONFIRM_TIME");

        if (TryGetConstant("MULTI_LEVEL_SELECT_TIME", out string? readMultiLevelSelectTime) &&
            Int32.TryParse(readMultiLevelSelectTime, out int intReadMultiLevelSelectTime))
            MultiLevelSelectTime = intReadMultiLevelSelectTime;
        else
            failedToReadConstantNames.Add("MULTI_LEVEL_SELECT_TIME");

        if (TryGetConstant("MULTI_LIVE_TIME_OUT", out string? readMultiLiveTimeOut) &&
            Int32.TryParse(readMultiLiveTimeOut, out int intReadMultiLiveTimeOut))
            MultiLiveTimeOut = intReadMultiLiveTimeOut;
        else
            failedToReadConstantNames.Add("MULTI_LIVE_TIME_OUT");

        if (TryGetConstant("MULTI_MUSIC_SELECT_TIME", out string? readMultiMusicSelectTime) &&
            Int32.TryParse(readMultiMusicSelectTime, out int intReadMultiMusicSelectTime))
            MultiMusicSelectTime = intReadMultiMusicSelectTime;
        else
            failedToReadConstantNames.Add("MULTI_MUSIC_SELECT_TIME");

        if (TryGetConstant("MULTI_PENALTY_DEFAULT_ID", out string? readMultiPenaltyDefaultId) &&
            Int32.TryParse(readMultiPenaltyDefaultId, out int intReadMultiPenaltyDefaultId))
            MultiPenaltyDefaultId = intReadMultiPenaltyDefaultId;
        else
            failedToReadConstantNames.Add("MULTI_PENALTY_DEFAULT_ID");

        if (TryGetConstant("MULTI_PENALTY_MISS_RATIO", out string? readMultiPenaltyMissRatio) &&
            Int32.TryParse(readMultiPenaltyMissRatio, out int intReadMultiPenaltyMissRatio))
            MultiPenaltyMissRatio = intReadMultiPenaltyMissRatio;
        else
            failedToReadConstantNames.Add("MULTI_PENALTY_MISS_RATIO");

        if (TryGetConstant("MULTI_PENALTY_NO_PLAY_MISS_RATIO", out string? readMultiPenaltyNoPlayMissRatio) &&
            Int32.TryParse(readMultiPenaltyNoPlayMissRatio, out int intReadMultiPenaltyNoPlayMissRatio))
            MultiPenaltyNoPlayMissRatio = intReadMultiPenaltyNoPlayMissRatio;
        else
            failedToReadConstantNames.Add("MULTI_PENALTY_NO_PLAY_MISS_RATIO");

        if (TryGetConstant("MULTI_PRIVATE_ROOM_ID_FORMAT", out string? readMultiPrivateRoomIdFormat) &&
            Int32.TryParse(readMultiPrivateRoomIdFormat, out int intReadMultiPrivateRoomIdFormat))
            MultiPrivateRoomIdFormat = intReadMultiPrivateRoomIdFormat;
        else
            failedToReadConstantNames.Add("MULTI_PRIVATE_ROOM_ID_FORMAT");

        if (TryGetConstant("MULTI_PRIVATE_ROOM_MAX_ID", out string? readMultiPrivateRoomMaxId) &&
            Int32.TryParse(readMultiPrivateRoomMaxId, out int intReadMultiPrivateRoomMaxId))
            MultiPrivateRoomMaxId = intReadMultiPrivateRoomMaxId;
        else
            failedToReadConstantNames.Add("MULTI_PRIVATE_ROOM_MAX_ID");

        if (TryGetConstant("MULTI_PRIVATE_ROOM_MIN_ID", out string? readMultiPrivateRoomMinId) &&
            Int32.TryParse(readMultiPrivateRoomMinId, out int intReadMultiPrivateRoomMinId))
            MultiPrivateRoomMinId = intReadMultiPrivateRoomMinId;
        else
            failedToReadConstantNames.Add("MULTI_PRIVATE_ROOM_MIN_ID");

        if (TryGetConstant("MULTI_PRIVATE_ROOM_PASS", out string? readMultiPrivateRoomPass) &&
            Int32.TryParse(readMultiPrivateRoomPass, out int intReadMultiPrivateRoomPass))
            MultiPrivateRoomPass = intReadMultiPrivateRoomPass;
        else
            failedToReadConstantNames.Add("MULTI_PRIVATE_ROOM_PASS");

        if (TryGetConstant("MULTI_PRIVATE_ROOM_PASS_COUNT", out string? readMultiPrivateRoomPassCount) &&
            Int32.TryParse(readMultiPrivateRoomPassCount, out int intReadMultiPrivateRoomPassCount))
            MultiPrivateRoomPassCount = intReadMultiPrivateRoomPassCount;
        else
            failedToReadConstantNames.Add("MULTI_PRIVATE_ROOM_PASS_COUNT");

        if (TryGetConstant("MULTI_REGION", out string? readMultiRegion))
            MultiRegion = readMultiRegion;
        else
            failedToReadConstantNames.Add("MULTI_REGION");

        if (TryGetConstant("MULTI_ROOM_MAX_ID", out string? readMultiRoomMaxId) &&
            Int32.TryParse(readMultiRoomMaxId, out int intReadMultiRoomMaxId))
            MultiRoomMaxId = intReadMultiRoomMaxId;
        else
            failedToReadConstantNames.Add("MULTI_ROOM_MAX_ID");

        if (TryGetConstant("MULTI_ROOM_MIN_ID", out string? readMultiRoomMinId) &&
            Int32.TryParse(readMultiRoomMinId, out int intReadMultiRoomMinId))
            MultiRoomMinId = intReadMultiRoomMinId;
        else
            failedToReadConstantNames.Add("MULTI_ROOM_MIN_ID");

        if (TryGetConstant("MUSE_STORY_TRACKING_LIST", out string? readMuseStoryTrackingList))
            MuseStoryTrackingList = readMuseStoryTrackingList;
        else
            failedToReadConstantNames.Add("MUSE_STORY_TRACKING_LIST");

        if (TryGetConstant("MUSIC_CHANGE_PRICE", out string? readMusicChangePrice) &&
            Int32.TryParse(readMusicChangePrice, out int intReadMusicChangePrice))
            MusicChangePrice = intReadMusicChangePrice;
        else
            failedToReadConstantNames.Add("MUSIC_CHANGE_PRICE");

        if (TryGetConstant("NIGIGASAKI_STORY_TRACKING_LIST", out string? readNigigasakiStoryTrackingList))
            NigigasakiStoryTrackingList = readNigigasakiStoryTrackingList;
        else
            failedToReadConstantNames.Add("NIGIGASAKI_STORY_TRACKING_LIST");

        if (TryGetConstant("ONE_MEGA_BYTE_TO_BYTE", out string? readOneMegaByteToByte) &&
            Int32.TryParse(readOneMegaByteToByte, out int intReadOneMegaByteToByte))
            OneMegaByteToByte = intReadOneMegaByteToByte;
        else
            failedToReadConstantNames.Add("ONE_MEGA_BYTE_TO_BYTE");

        if (TryGetConstant("PICK_ADJUST_NUMBER", out string? readPickAdjustNumber) &&
            Int32.TryParse(readPickAdjustNumber, out int intReadPickAdjustNumber))
            PickAdjustNumber = intReadPickAdjustNumber;
        else
            failedToReadConstantNames.Add("PICK_ADJUST_NUMBER");

        if (TryGetConstant("PICK_SCORE_BONUS_DENOMINATOR", out string? readPickScoreBonusDenominator) &&
            Int32.TryParse(readPickScoreBonusDenominator, out int intReadPickScoreBonusDenominator))
            PickScoreBonusDenominator = intReadPickScoreBonusDenominator;
        else
            failedToReadConstantNames.Add("PICK_SCORE_BONUS_DENOMINATOR");

        if (TryGetConstant("PICK_SCORE_BONUS_NUMERATOR", out string? readPickScoreBonusNumerator) &&
            Int32.TryParse(readPickScoreBonusNumerator, out int intReadPickScoreBonusNumerator))
            PickScoreBonusNumerator = intReadPickScoreBonusNumerator;
        else
            failedToReadConstantNames.Add("PICK_SCORE_BONUS_NUMERATOR");

        if (TryGetConstant("PLAYER_RANKS_TRACKING_LIST", out string? readPlayerRanksTrackingList) &&
            SlashDelimitedListParser.TryParse(readPlayerRanksTrackingList, out List<int> listReadPlayerRanksTrackingList))
            PlayerRanksTrackingList = listReadPlayerRanksTrackingList;
        else
            failedToReadConstantNames.Add("PLAYER_RANKS_TRACKING_LIST");

        if (TryGetConstant("PRESENT_BOX_EXPIRE_NOTIFY_HOUR", out string? readPresentBoxExpireNotifyHour) &&
            Int32.TryParse(readPresentBoxExpireNotifyHour, out int intReadPresentBoxExpireNotifyHour))
            PresentBoxExpireNotifyHour = intReadPresentBoxExpireNotifyHour;
        else
            failedToReadConstantNames.Add("PRESENT_BOX_EXPIRE_NOTIFY_HOUR");

        if (TryGetConstant("PURCHASE", out string? readPurchase))
            Purchase = readPurchase;
        else
            failedToReadConstantNames.Add("PURCHASE");

        if (TryGetConstant("RANK_005", out string? readRank005))
            Rank005 = readRank005;
        else
            failedToReadConstantNames.Add("RANK_005");

        if (TryGetConstant("RANK_010", out string? readRank010))
            Rank010 = readRank010;
        else
            failedToReadConstantNames.Add("RANK_010");

        if (TryGetConstant("RANK_030", out string? readRank030))
            Rank030 = readRank030;
        else
            failedToReadConstantNames.Add("RANK_030");

        if (TryGetConstant("RANK_050", out string? readRank050))
            Rank050 = readRank050;
        else
            failedToReadConstantNames.Add("RANK_050");

        if (TryGetConstant("RANK_100", out string? readRank100))
            Rank100 = readRank100;
        else
            failedToReadConstantNames.Add("RANK_100");

        if (TryGetConstant("RANK_200", out string? readRank200))
            Rank200 = readRank200;
        else
            failedToReadConstantNames.Add("RANK_200");

        if (TryGetConstant("RANK_300", out string? readRank300))
            Rank300 = readRank300;
        else
            failedToReadConstantNames.Add("RANK_300");

        if (TryGetConstant("REJECT_PURCHASE_FLAG", out string? readRejectPurchaseFlag) &&
            Boolean.TryParse(readRejectPurchaseFlag, out bool flagReadRejectPurchaseFlag))
            RejectPurchaseFlag = flagReadRejectPurchaseFlag;
        else
            failedToReadConstantNames.Add("REJECT_PURCHASE_FLAG");

        if (TryGetConstant("SCORE_DECK_POWER_COEFFICIENT", out string? readScoreDeckPowerCoefficient) &&
            Decimal.TryParse(readScoreDeckPowerCoefficient, out decimal decReadScoreDeckPowerCoefficient))
            ScoreDeckPowerCoefficient = decReadScoreDeckPowerCoefficient;
        else
            failedToReadConstantNames.Add("SCORE_DECK_POWER_COEFFICIENT");

        if (TryGetConstant("SCORE_LEVEL_ADJUST_COEFFICIENT", out string? readScoreLevelAdjustCoefficient) &&
            Decimal.TryParse(readScoreLevelAdjustCoefficient, out decimal decReadScoreLevelAdjustCoefficient))
            ScoreLevelAdjustCoefficient = decReadScoreLevelAdjustCoefficient;
        else
            failedToReadConstantNames.Add("SCORE_LEVEL_ADJUST_COEFFICIENT");

        if (TryGetConstant("SCORE_LEVEL_MIN_COEFFICIENT", out string? readScoreLevelMinCoefficient) &&
            Int32.TryParse(readScoreLevelMinCoefficient, out int intReadScoreLevelMinCoefficient))
            ScoreLevelMinCoefficient = intReadScoreLevelMinCoefficient;
        else
            failedToReadConstantNames.Add("SCORE_LEVEL_MIN_COEFFICIENT");

        if (TryGetConstant("SCORE_TOTAL_POWER_COEFFICIENT", out string? readScoreTotalPowerCoefficient) &&
            Int32.TryParse(readScoreTotalPowerCoefficient, out int intReadScoreTotalPowerCoefficient))
            ScoreTotalPowerCoefficient = intReadScoreTotalPowerCoefficient;
        else
            failedToReadConstantNames.Add("SCORE_TOTAL_POWER_COEFFICIENT");

        if (TryGetConstant("SERIF_HIDE_TIME", out string? readSerifHideTime) &&
            Int32.TryParse(readSerifHideTime, out int intReadSerifHideTime))
            SerifHideTime = intReadSerifHideTime;
        else
            failedToReadConstantNames.Add("SERIF_HIDE_TIME");

        if (TryGetConstant("SKILL_REINFORCE_SAME_CARD_RATIO", out string? readSkillReinforceSameCardRatio) &&
            Int32.TryParse(readSkillReinforceSameCardRatio, out int intReadSkillReinforceSameCardRatio))
            SkillReinforceSameCardRatio = intReadSkillReinforceSameCardRatio;
        else
            failedToReadConstantNames.Add("SKILL_REINFORCE_SAME_CARD_RATIO");

        if (TryGetConstant("SPIRIT_ADJUST_NUMBER", out string? readSpiritAdjustNumber) &&
            Int32.TryParse(readSpiritAdjustNumber, out int intReadSpiritAdjustNumber))
            SpiritAdjustNumber = intReadSpiritAdjustNumber;
        else
            failedToReadConstantNames.Add("SPIRIT_ADJUST_NUMBER");

        if (TryGetConstant("SPIRIT_SCORE_BONUS_DENOMINATOR", out string? readSpiritScoreBonusDenominator) &&
            Int32.TryParse(readSpiritScoreBonusDenominator, out int intReadSpiritScoreBonusDenominator))
            SpiritScoreBonusDenominator = intReadSpiritScoreBonusDenominator;
        else
            failedToReadConstantNames.Add("SPIRIT_SCORE_BONUS_DENOMINATOR");

        if (TryGetConstant("SPIRIT_SCORE_BONUS_NUMERATOR", out string? readSpiritScoreBonusNumerator) &&
            Int32.TryParse(readSpiritScoreBonusNumerator, out int intReadSpiritScoreBonusNumerator))
            SpiritScoreBonusNumerator = intReadSpiritScoreBonusNumerator;
        else
            failedToReadConstantNames.Add("SPIRIT_SCORE_BONUS_NUMERATOR");

        if (TryGetConstant("SS_ALIGNMENT_END_DATETIME", out string? readSsAlignmentEndDatetime) &&
            DateTimeOffset.TryParse(readSsAlignmentEndDatetime, out DateTimeOffset dtoReadSsAlignmentEndDatetime))
            SsAlignmentEndDatetime = dtoReadSsAlignmentEndDatetime;
        else
            failedToReadConstantNames.Add("SS_ALIGNMENT_END_DATETIME");

        if (TryGetConstant("SS_THEATER_NOT_FOUND", out string? readSsTheaterNotFound))
            SsTheaterNotFound = readSsTheaterNotFound;
        else
            failedToReadConstantNames.Add("SS_THEATER_NOT_FOUND");

        if (TryGetConstant("STAMINA_RECOVER_TIME", out string? readStaminaRecoverTime) &&
            Int32.TryParse(readStaminaRecoverTime, out int intReadStaminaRecoverTime))
            StaminaRecoverTime = intReadStaminaRecoverTime;
        else
            failedToReadConstantNames.Add("STAMINA_RECOVER_TIME");

        if (TryGetConstant("STAMINA_RECOVER_VALUE", out string? readStaminaRecoverValue) &&
            Int32.TryParse(readStaminaRecoverValue, out int intReadStaminaRecoverValue))
            StaminaRecoverValue = intReadStaminaRecoverValue;
        else
            failedToReadConstantNames.Add("STAMINA_RECOVER_VALUE");

        if (TryGetConstant("STAMP_ONE_PAGE_NUM", out string? readStampOnePageNum) &&
            Int32.TryParse(readStampOnePageNum, out int intReadStampOnePageNum))
            StampOnePageNum = intReadStampOnePageNum;
        else
            failedToReadConstantNames.Add("STAMP_ONE_PAGE_NUM");

        if (TryGetConstant("STAR_ASSIST_CARD_BONUS_COEFFICIENT", out string? readStarAssistCardBonusCoefficient) &&
            Int32.TryParse(readStarAssistCardBonusCoefficient, out int intReadStarAssistCardBonusCoefficient))
            StarAssistCardBonusCoefficient = intReadStarAssistCardBonusCoefficient;
        else
            failedToReadConstantNames.Add("STAR_ASSIST_CARD_BONUS_COEFFICIENT");

        if (TryGetConstant("STAR_ASSIST_CARD_COEFFICIENT", out string? readStarAssistCardCoefficient) &&
            Int32.TryParse(readStarAssistCardCoefficient, out int intReadStarAssistCardCoefficient))
            StarAssistCardCoefficient = intReadStarAssistCardCoefficient;
        else
            failedToReadConstantNames.Add("STAR_ASSIST_CARD_COEFFICIENT");

        if (TryGetConstant("STAR_ASSIST_SKILL_COEFFICIENT_1", out string? readStarAssistSkillCoefficient1) &&
            Int32.TryParse(readStarAssistSkillCoefficient1, out int intReadStarAssistSkillCoefficient1))
            StarAssistSkillCoefficient1 = intReadStarAssistSkillCoefficient1;
        else
            failedToReadConstantNames.Add("STAR_ASSIST_SKILL_COEFFICIENT_1");

        if (TryGetConstant("STAR_ASSIST_SKILL_COEFFICIENT_2", out string? readStarAssistSkillCoefficient2) &&
            Int32.TryParse(readStarAssistSkillCoefficient2, out int intReadStarAssistSkillCoefficient2))
            StarAssistSkillCoefficient2 = intReadStarAssistSkillCoefficient2;
        else
            failedToReadConstantNames.Add("STAR_ASSIST_SKILL_COEFFICIENT_2");

        if (TryGetConstant("STAR_ASSIST_SKILL_PROBABILITY", out string? readStarAssistSkillProbability) &&
            Int32.TryParse(readStarAssistSkillProbability, out int intReadStarAssistSkillProbability))
            StarAssistSkillProbability = intReadStarAssistSkillProbability;
        else
            failedToReadConstantNames.Add("STAR_ASSIST_SKILL_PROBABILITY");

        if (TryGetConstant("STAR_BONUS_COEFFICIENT", out string? readStarBonusCoefficient) &&
            Int32.TryParse(readStarBonusCoefficient, out int intReadStarBonusCoefficient))
            StarBonusCoefficient = intReadStarBonusCoefficient;
        else
            failedToReadConstantNames.Add("STAR_BONUS_COEFFICIENT");

        if (TryGetConstant("STAR_EVENT_BONUS_COEFFICIENT", out string? readStarEventBonusCoefficient) &&
            Int32.TryParse(readStarEventBonusCoefficient, out int intReadStarEventBonusCoefficient))
            StarEventBonusCoefficient = intReadStarEventBonusCoefficient;
        else
            failedToReadConstantNames.Add("STAR_EVENT_BONUS_COEFFICIENT");

        if (TryGetConstant("STAR_EVENT_BONUS_MAX_DAILY_COUNT", out string? readStarEventBonusMaxDailyCount) &&
            Int32.TryParse(readStarEventBonusMaxDailyCount, out int intReadStarEventBonusMaxDailyCount))
            StarEventBonusMaxDailyCount = intReadStarEventBonusMaxDailyCount;
        else
            failedToReadConstantNames.Add("STAR_EVENT_BONUS_MAX_DAILY_COUNT");

        if (TryGetConstant("STORYCLEAR_AQOURS_01", out string? readStoryclearAqours01))
            StoryclearAqours01 = readStoryclearAqours01;
        else
            failedToReadConstantNames.Add("STORYCLEAR_AQOURS_01");

        if (TryGetConstant("STORYCLEAR_AQOURS_02", out string? readStoryclearAqours02))
            StoryclearAqours02 = readStoryclearAqours02;
        else
            failedToReadConstantNames.Add("STORYCLEAR_AQOURS_02");

        if (TryGetConstant("STORYCLEAR_AQOURS_03", out string? readStoryclearAqours03))
            StoryclearAqours03 = readStoryclearAqours03;
        else
            failedToReadConstantNames.Add("STORYCLEAR_AQOURS_03");

        if (TryGetConstant("STORYCLEAR_AQOURS_04", out string? readStoryclearAqours04))
            StoryclearAqours04 = readStoryclearAqours04;
        else
            failedToReadConstantNames.Add("STORYCLEAR_AQOURS_04");

        if (TryGetConstant("STORYCLEAR_AQOURS_05", out string? readStoryclearAqours05))
            StoryclearAqours05 = readStoryclearAqours05;
        else
            failedToReadConstantNames.Add("STORYCLEAR_AQOURS_05");

        if (TryGetConstant("STORYCLEAR_MS_01", out string? readStoryclearMs01))
            StoryclearMs01 = readStoryclearMs01;
        else
            failedToReadConstantNames.Add("STORYCLEAR_MS_01");

        if (TryGetConstant("STORYCLEAR_MS_02", out string? readStoryclearMs02))
            StoryclearMs02 = readStoryclearMs02;
        else
            failedToReadConstantNames.Add("STORYCLEAR_MS_02");

        if (TryGetConstant("STORYCLEAR_MS_03", out string? readStoryclearMs03))
            StoryclearMs03 = readStoryclearMs03;
        else
            failedToReadConstantNames.Add("STORYCLEAR_MS_03");

        if (TryGetConstant("STORYCLEAR_MS_04", out string? readStoryclearMs04))
            StoryclearMs04 = readStoryclearMs04;
        else
            failedToReadConstantNames.Add("STORYCLEAR_MS_04");

        if (TryGetConstant("STORYCLEAR_MS_05", out string? readStoryclearMs05))
            StoryclearMs05 = readStoryclearMs05;
        else
            failedToReadConstantNames.Add("STORYCLEAR_MS_05");

        if (TryGetConstant("STORYCLEAR_NIJI_01", out string? readStoryclearNiji01))
            StoryclearNiji01 = readStoryclearNiji01;
        else
            failedToReadConstantNames.Add("STORYCLEAR_NIJI_01");

        if (TryGetConstant("STORYCLEAR_NIJI_02", out string? readStoryclearNiji02))
            StoryclearNiji02 = readStoryclearNiji02;
        else
            failedToReadConstantNames.Add("STORYCLEAR_NIJI_02");

        if (TryGetConstant("STORYCLEAR_NIJI_03", out string? readStoryclearNiji03))
            StoryclearNiji03 = readStoryclearNiji03;
        else
            failedToReadConstantNames.Add("STORYCLEAR_NIJI_03");

        if (TryGetConstant("STORYCLEAR_NIJI_04", out string? readStoryclearNiji04))
            StoryclearNiji04 = readStoryclearNiji04;
        else
            failedToReadConstantNames.Add("STORYCLEAR_NIJI_04");

        if (TryGetConstant("STORYCLEAR_NIJI_05", out string? readStoryclearNiji05))
            StoryclearNiji05 = readStoryclearNiji05;
        else
            failedToReadConstantNames.Add("STORYCLEAR_NIJI_05");

        if (TryGetConstant("TALK_USER_EXP_BASE", out string? readTalkUserExpBase) &&
            Int32.TryParse(readTalkUserExpBase, out int intReadTalkUserExpBase))
            TalkUserExpBase = intReadTalkUserExpBase;
        else
            failedToReadConstantNames.Add("TALK_USER_EXP_BASE");

        if (TryGetConstant("TUTORIAL_CARD_REINFORCE_MASTER_ITEM_ID", out string? readTutorialCardReinforceMasterItemId) &&
            Int32.TryParse(readTutorialCardReinforceMasterItemId, out int intReadTutorialCardReinforceMasterItemId))
            TutorialCardReinforceMasterItemId = intReadTutorialCardReinforceMasterItemId;
        else
            failedToReadConstantNames.Add("TUTORIAL_CARD_REINFORCE_MASTER_ITEM_ID");

        if (TryGetConstant("TUTORIAL_COMPLETE", out string? readTutorialComplete))
            TutorialComplete = readTutorialComplete;
        else
            failedToReadConstantNames.Add("TUTORIAL_COMPLETE");

        if (TryGetConstant("TUTORIAL_EXCLUDE_MEMBER", out string? readTutorialExcludeMember) &&
            SlashDelimitedListParser.TryParse(readTutorialExcludeMember, out List<int> listReadTutorialExcludeMember))
            TutorialExcludeMember = listReadTutorialExcludeMember;
        else
            failedToReadConstantNames.Add("TUTORIAL_EXCLUDE_MEMBER");

        if (TryGetConstant("TUTORIAL_GUEST_USER_CARD_LEVEL", out string? readTutorialGuestUserCardLevel) &&
            Int32.TryParse(readTutorialGuestUserCardLevel, out int intReadTutorialGuestUserCardLevel))
            TutorialGuestUserCardLevel = intReadTutorialGuestUserCardLevel;
        else
            failedToReadConstantNames.Add("TUTORIAL_GUEST_USER_CARD_LEVEL");

        if (TryGetConstant("TUTORIAL_GUEST_USER_COMMENT", out string? readTutorialGuestUserComment))
            TutorialGuestUserComment = readTutorialGuestUserComment;
        else
            failedToReadConstantNames.Add("TUTORIAL_GUEST_USER_COMMENT");

        if (TryGetConstant("TUTORIAL_GUEST_USER_MASTER_CARD_ID", out string? readTutorialGuestUserMasterCardId) &&
            Int32.TryParse(readTutorialGuestUserMasterCardId, out int intReadTutorialGuestUserMasterCardId))
            TutorialGuestUserMasterCardId = intReadTutorialGuestUserMasterCardId;
        else
            failedToReadConstantNames.Add("TUTORIAL_GUEST_USER_MASTER_CARD_ID");

        if (TryGetConstant("TUTORIAL_GUEST_USER_NAME", out string? readTutorialGuestUserName))
            TutorialGuestUserName = readTutorialGuestUserName;
        else
            failedToReadConstantNames.Add("TUTORIAL_GUEST_USER_NAME");

        if (TryGetConstant("TUTORIAL_GUEST_USER_RANK", out string? readTutorialGuestUserRank) &&
            Int32.TryParse(readTutorialGuestUserRank, out int intReadTutorialGuestUserRank))
            TutorialGuestUserRank = intReadTutorialGuestUserRank;
        else
            failedToReadConstantNames.Add("TUTORIAL_GUEST_USER_RANK");

        if (TryGetConstant("TUTORIAL_GUEST_USER_TITLE_ID", out string? readTutorialGuestUserTitleId) &&
            Int32.TryParse(readTutorialGuestUserTitleId, out int intReadTutorialGuestUserTitleId))
            TutorialGuestUserTitleId = intReadTutorialGuestUserTitleId;
        else
            failedToReadConstantNames.Add("TUTORIAL_GUEST_USER_TITLE_ID");

        if (TryGetConstant("TUTORIAL_MASTER_STORY_PART_ID", out string? readTutorialMasterStoryPartId) &&
            Int32.TryParse(readTutorialMasterStoryPartId, out int intReadTutorialMasterStoryPartId))
            TutorialMasterStoryPartId = intReadTutorialMasterStoryPartId;
        else
            failedToReadConstantNames.Add("TUTORIAL_MASTER_STORY_PART_ID");

        if (TryGetConstant("TUTORIAL_MASTER_TALK_ID", out string? readTutorialMasterTalkId) &&
            Int32.TryParse(readTutorialMasterTalkId, out int intReadTutorialMasterTalkId))
            TutorialMasterTalkId = intReadTutorialMasterTalkId;
        else
            failedToReadConstantNames.Add("TUTORIAL_MASTER_TALK_ID");

        if (TryGetConstant("TUTORIAL_MIN_LOTTERY_ID", out string? readTutorialMinLotteryId) &&
            Int32.TryParse(readTutorialMinLotteryId, out int intReadTutorialMinLotteryId))
            TutorialMinLotteryId = intReadTutorialMinLotteryId;
        else
            failedToReadConstantNames.Add("TUTORIAL_MIN_LOTTERY_ID");

        if (TryGetConstant("TUTORIAL_SPEECH_BUBBLE_MISSION_1", out string? readTutorialSpeechBubbleMission1) &&
            Int32.TryParse(readTutorialSpeechBubbleMission1, out int intReadTutorialSpeechBubbleMission1))
            TutorialSpeechBubbleMission1 = intReadTutorialSpeechBubbleMission1;
        else
            failedToReadConstantNames.Add("TUTORIAL_SPEECH_BUBBLE_MISSION_1");

        if (TryGetConstant("TUTORIAL_SPEECH_BUBBLE_MISSION_2", out string? readTutorialSpeechBubbleMission2) &&
            Int32.TryParse(readTutorialSpeechBubbleMission2, out int intReadTutorialSpeechBubbleMission2))
            TutorialSpeechBubbleMission2 = intReadTutorialSpeechBubbleMission2;
        else
            failedToReadConstantNames.Add("TUTORIAL_SPEECH_BUBBLE_MISSION_2");

        if (TryGetConstant("TUTORIAL_SPEECH_BUBBLE_MISSION_3", out string? readTutorialSpeechBubbleMission3) &&
            Int32.TryParse(readTutorialSpeechBubbleMission3, out int intReadTutorialSpeechBubbleMission3))
            TutorialSpeechBubbleMission3 = intReadTutorialSpeechBubbleMission3;
        else
            failedToReadConstantNames.Add("TUTORIAL_SPEECH_BUBBLE_MISSION_3");

        if (TryGetConstant("USERNAME_COMPLETE", out string? readUsernameComplete))
            UsernameComplete = readUsernameComplete;
        else
            failedToReadConstantNames.Add("USERNAME_COMPLETE");
    }
}
