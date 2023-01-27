using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.model
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QtLinhas) LerArquivo (string caminho)
        {
            try
            {

            string[] linhas = File.ReadAllLines(caminho);
           
            return(true, linhas,linhas.Count());
            }catch(Exception )
            {
                return(false, null, 0);
            }
            
        }
    }
}