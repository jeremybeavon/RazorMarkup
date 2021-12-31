﻿namespace RazorMarkup.Database.SqlServer
{
    public sealed class Procedure<TParameters, TOutput>
    {
        public Procedure(ProcedureName name)
        {
            Name = name;
        }

        public Procedure(string name)
            : this(new ProcedureName(name))
        {
        }

        public ProcedureName Name { get; private set; }

        public TParameters Parameters => throw new NotInExpressionException();

        public TOutput Output => throw new NotInExpressionException();
    }
}
