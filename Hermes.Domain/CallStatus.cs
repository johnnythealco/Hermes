using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class CallStatus
    {
        public int Id { get; set; }
        public int IeSM_CALL_STATUS_ID { get; set; }
        public string Description { get; set; }
        public DateTime DateModified { get; set; }
    }
}
