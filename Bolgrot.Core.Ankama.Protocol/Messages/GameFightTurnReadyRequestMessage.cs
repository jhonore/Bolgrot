using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolgrot.Core.Ankama.Protocol.Messages
{
    public class GameFightTurnReadyRequestMessage : NetworkMessage
    {

	    public int id;


        public GameFightTurnReadyRequestMessage()
        {
        }

        public GameFightTurnReadyRequestMessage(int id)
        {
            this.id = id;

        }
    }
}