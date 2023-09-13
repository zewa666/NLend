namespace NLendApp
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false)]
	public class InjectState<T> : Attribute
	{
        public string Selector { get; set; }
        public Type Type { get; set; }
        public InjectState(string selector)
        {
            Selector = selector;
            Type = typeof(T);
        }
    }
}
