using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03_Events.Lib.Mensagens
{
    public class Email
    {
        public void EnviarMensagem(Video video)
        {
            Console.WriteLine("EMAIL enviado para o vídeo" + video.Nome);
        }
    }
}
