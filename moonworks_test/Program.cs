using System;
using moonworks_test;
using MoonWorks;
var debugMode = false;

#if DEBUG
debugMode = true;
#endif

var windowCreateInfo = new WindowCreateInfo(
    "MoonWorksTest",
    640,
    480,
    ScreenMode.Windowed
);

var framePacingSettings = FramePacingSettings.CreateCapped(60, 120);

var game = new Game1(
    windowCreateInfo,
    framePacingSettings,
    debugMode
);

game.Run();