namespace Unity.State
{
    public class StateResult
    {
        public readonly int nextStateId;
        public readonly object resultData;

        public StateResult(int nextStateId, object resultData = null)
        {
            this.nextStateId = nextStateId;
            this.resultData = resultData;
        }
    }
}
