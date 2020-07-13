using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolgrot.Core.Ankama.Protocol.Messages
{
    public class BasicPongMessage : NetworkMessage
    {

	    public bool quiet;


        public BasicPongMessage()
        {
        }

        public BasicPongMessage(bool quiet)
        {
            this.quiet = quiet;

        }
    }
}