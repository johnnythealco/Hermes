using System;


namespace Hermes.Domain
{
    public class CallPriority
    {
        public CallPriority()
        {

        }

        public CallPriority(int _IeSM_SUB_CATEGORY_ID, String _description)
        {
            IeSM_SUB_CATEGORY_ID = _IeSM_SUB_CATEGORY_ID;
            Description = _description;
        }

        public int Id { get; set; }
        public int IeSM_SUB_CATEGORY_ID { get; set; }
        public string Description { get; set; }
        public DateTime DateModified { get; set; }
    }
}
