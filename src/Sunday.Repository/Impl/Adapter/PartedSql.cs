﻿namespace Sunday.Repository.Impl.Adapter
{
    /// <summary>
    /// sql info
    /// </summary>
    public struct PartedSql
    {
        public string Raw;
        /// <summary>
        /// select eg：distinct Id, name
        /// </summary>
        public string Select;

        /// <summary>
        /// body eg：tabName where Id = 123
        /// </summary>
        public string Body;

        /// <summary>
        /// order by eg: Id Asc
        /// </summary>
        public string OrderBy;
    }
}
