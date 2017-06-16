using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class CallCategory
    {
        public int Id { get; set; }
        public int IeSM_CALL_CATEGORY_ID { get; set; }
        public string Description { get; set; }
        public DateTime DateModified { get; set; }
    }
}
