using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A03_Events.Lib
{
    public class VideoEncode
    {
        public delegate void VideoEncodedHandler(Video video);
        public event VideoEncodedHandler Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Convertendo o vídeo...");
            //vai para por 2s e continuar
            Thread.Sleep(2000);
            Console.WriteLine("Vídeo Convertido");

            Encoded(video);
        }
    }
}
