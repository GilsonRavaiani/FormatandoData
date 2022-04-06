using System;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();

            var data = DateTime.Now;

            //var formatada = String.Format("{0}", data);

            //var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z} Hoje é seu dia bebê", data);
            var formatada = String.Format("{0:s} Hoje é seu dia bebê", data);
            //(t=tempo)(d=data)(D=data extenso)(f=combinaDataHora)(g=datahorashort)(r=padraointer)(s=padraoData)
            Console.WriteLine(formatada);
           

            


        }
    }
}
