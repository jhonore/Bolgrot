using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolgrot.Core.Ankama.Protocol.Messages
{
    public class GuildMemberWarnOnConnectionStateMessage : NetworkMessage
    {

	    public bool enable;


        public GuildMemberWarnOnConnectionStateMessage()
        {
        }

        public GuildMemberWarnOnConnectionStateMessage(bool enable)
        {
            this.enable = enable;

        }
    }
}