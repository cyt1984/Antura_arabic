﻿namespace Antura
{
    public enum Music
    {
        DontChange = -2, // dont' change music
        Custom = -1, // a custom AudioClip is passed to MusicPlayer
        Silence = 0, // no music : do slience please
        MainTheme = 1,
        Relax = 2,
        Lullaby = 3,
        Theme6 = 6,
        Theme7 = 7,
        Theme8 = 8,
        Theme9 = 9,
        Theme10 = 10
    }

    // last is 73
    public enum Sfx
    {
        AlarmClock = 13,
        BallHit = 31,
        BalloonPop = 2,
        Blip = 62,
        BushRustlingIn = 32,
        BushRustlingOut = 33,
        CameraMovement = 12,
        CameraMovementShort = 63,
        ChoiceSwipe = 64,
        CrateLandOnground = 34,
        DangerClock = 3,
        DangerClockLong = 4,
        DogBarking = 22,
        DogSnoring = 23,
        DogSnorting = 24,
        Dog_Exhale = 60,
        Dog_Inhale = 61,
        Dog_Noize = 69,
        Dog_Scared = 70,
        EggBreak = 40,
        EggMove = 41,
        GameTitle = 5,
        Hit = 1,
        KO = 26,
        LetterAngry = 14,
        LetterFear = 18,
        LetterHappy = 15,
        LetterHold = 17,
        LetterSad = 16,
        LL_Afraid = 46,
        LL_Annoyed = 47,
        LL_Giggle = 48,
        LL_Jump = 50,
        LL_La = 51,
        LL_Laugh = 52,
        LL_No1 = 53,
        LL_No2 = 54,
        LL_No3 = 55,
        LL_Sleep = 56,
        LL_Surprise = 57,
        LL_Suspicious = 58,
        LL_Tada = 59,
        LL_Yeah = 49,
        Lose = 7,
        OK = 25,
        Photo = 71,
        PipeBlowIn = 35,
        PipeBlowOut = 36,
        Poof = 37,
        RocketMove = 66,
        ScaleDown = 43,
        ScaleUp = 44,
        ScoreDown = 72,
        ScoreUp = 73,
        ScreenHit = 38,
        ScreenGlassHit = 65,
        Splat = 30,
        StampOK = 29,
        StarFlower = 28,
        ThrowArm = 42,
        ThrowObj = 39,
        TickAndWin = 45,
        Transition = 27,
        TrapdoorClose = 67,
        TrapdoorOpen = 68,
        UIButtonClick = 9,
        UIPauseIn = 10,
        UIPauseOut = 11,
        UIPopup = 8,
        WalkieTalkie = 19,
        WheelStart = 20,
        WheelTick = 21,
        Win = 6
    }
}