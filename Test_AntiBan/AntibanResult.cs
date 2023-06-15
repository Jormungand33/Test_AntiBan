using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_AntiBan
{
    public class AntibanResult
    {
        /// <summary>
        /// Предполагаемое время отправки сообщения
        /// </summary>
        public DateTime SentDateTime { get; set; }
        public int EventMessageId { get; set; }
    }
}
