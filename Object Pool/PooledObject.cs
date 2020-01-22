using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Pool
{
    class PooledObject
    {
        DateTime _createdAt = DateTime.Now;
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
