﻿using Ekin.Clarizen.Interfaces;

namespace Ekin.Clarizen.Data.Queries
{
    public class groupsQuery : IQuery
    {
        public string _type { get { return "groupsQuery"; } }

        public string[] fields { get; set; }
        public paging paging { get; set; }

        public groupsQuery(string[] fields, paging paging)
        {
            this.fields = fields;
            this.paging = paging;
        }

        public groupsQuery(string[] fields)
        {
            this.fields = fields;
        }
    }
}