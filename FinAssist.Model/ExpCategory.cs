namespace FinAssist.Model
{
	public class ExpenditureCategory : EntityBase<int>
    {
        protected ExpenditureCategory() : base(-1)
        { }


        public ExpenditureCategory(string inName, ExpenditureCategory inParent) : base(-1)
		{
			CategoryName = inName;
			Parent = inParent;
		}

		public virtual string CategoryName { get; set; }
		public virtual ExpenditureCategory Parent { get; set; }
	}
}