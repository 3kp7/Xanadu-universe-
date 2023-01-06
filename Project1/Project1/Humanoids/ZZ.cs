namespace Project1
{
    class ZZ : Humanoid, ISpeakFrench,ICanDance
    {
        public string Mediaplay;

        public ZZ(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }

        public void Speak()
        {
            Mediaplay = "Assets/ZSpeak.mp3";
        }
        public void Sing()
        {
            Mediaplay = "Assets/SongAT.mp4";
        }
        public void Dance()
        {
            Mediaplay = "Assets/Rickroll2.mp4";
        }
        public override void Socialize()
        {
            Sing();
            Dance();
        }
        
    }
}
