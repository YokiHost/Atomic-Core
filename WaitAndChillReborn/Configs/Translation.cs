namespace WaitAndChillReborn.Configs
{
    using Exiled.API.Interfaces;

    public sealed class Translation : ITranslation
    {
        public string RoundCount { get; private set; } = "<size=40>{rounds} seconds remaining</size>";

        public string TopMessage { get; private set; } = "<size=30>The game begins: <color=#00bfcf>{seconds}</color></size>";

        public string BottomMessage { get; private set; } = "<size=25>👥 {players}</size>";

        public string ServerIsPaused { get; private set; } = "Server is paused";

        public string RoundIsBeingStarted { get; private set; } = "Round is being started";

        public string OneSecondRemain { get; private set; } = "second remains";

        public string XSecondsRemains { get; private set; } = "seconds remain";

        public string OnePlayerConnected { get; private set; } = "Players are connected";

        public string XPlayersConnected { get; private set; } = "Players are connected";

        public string ToggleNoClipInstructions { get; private set; } = "<size=40><color=yellow>Press [ALT] to Ready Up</color></size>";
        public string YouAreReady { get; private set; } = "You are Ready";
    }
}
