using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseIt.Repository.Entities
{
    public class ReleaseItem
    {
        public int ID { get; set; }

        public ReleaseDomainTypes DomainType { get; set; }

        public ReleaseTypes ReleaseType { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Uri { get; set; }

        public string User { get; set; }
    }
}
