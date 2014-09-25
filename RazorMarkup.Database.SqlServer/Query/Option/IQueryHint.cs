namespace RazorMarkup.Database.SqlServer.Query.Option
{
    public interface IQueryHint
    {
        IQueryHintAnd HashGroup();

        IQueryHintAnd OrderGroup();

        IQueryHintAnd ConcatUnion();

        IQueryHintAnd HashUnion();

        IQueryHintAnd MergeUnion();

        IQueryHintAnd LoopJoin();

        IQueryHintAnd MergeJoin();

        IQueryHintAnd HashJoin();

        IQueryHintAnd ExpandViews();

        IQueryHintAnd Fast(int numberOfRows);

        IQueryHintAnd ForceOrder();

        IQueryHintAnd IgnoreNonClusteredColumnStoreIndex();

        IQueryHintAnd KeepPlan();

        IQueryHintAnd KeepFixedPlan();

        IQueryHintAnd MaxDegreeOfParallelsim(int numberOfProcessors);

        IQueryHintAnd MaxRecursion(int number);

        IQueryHintOptimizeFor OptimizeFor();

        IQueryHintAnd OptimizeForUnknown();

        IQueryHintAnd ParameterizationSimple();

        IQueryHintAnd ParameterizationForced();

        IQueryHintAnd Recompile();

        IQueryHintAnd RobustPlan();

        IQueryHintAnd UsePlan(string xmlPlan);

        //TableHint
    }
}
