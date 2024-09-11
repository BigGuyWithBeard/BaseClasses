namespace BigGuyWithBeard.BaseClasses
{
    public class IBase
    {
        public Guid Id {get;set;}
        public bool IsDirty{get;set; }
        public Status Status {get; }
    }
}
