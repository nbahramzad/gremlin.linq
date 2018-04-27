﻿namespace Gremlin.Linq.Linq
{
    public class EdgeSelector<T> : Selector<T>
    {
        private readonly string _relation;

        public EdgeSelector(IGraphClient graphClient, string relation) : base(graphClient)
        {
            _relation = relation;
        }

        public override string BuildGremlinQuery()
        {
            return ParentSelector.BuildGremlinQuery() + $".out('{_relation}')";
        }
    }
}