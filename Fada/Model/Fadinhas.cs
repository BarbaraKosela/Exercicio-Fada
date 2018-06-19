using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fadinhas
    {
        private string nome;
        private string familia;
        private string cor;
        private string corAsa;
        private int tamanhoAsa;
        private bool asaQuebrada;
        private bool ehMulher;
        private bool fazBarulho;
        private string elemento;

         public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }

                if (value.Count() < 3)
                {
                    throw new Exception("Nome da fada deve conter no mínimo 3 caracteres");
                }

                if (value.Count() > 30)
                {
                    throw new Exception("Nome da fada deve conter no máximo 30 caracteres");
                }
                nome = value;
            }
         }


         public string Familia
         {
             get
             {
                 return familia;
             }
             set
             {

                 if (string.IsNullOrEmpty(value))
                 {
                     throw new Exception("Familia deve ser preenchida");
                 }

                 if (value.Count() < 3)
                 {
                     throw new Exception("Nome da família deve conter no mínimo 3 caracteres");
                 }

                 if (value.Count() > 30)
                 {
                     throw new Exception("Nome da família deve conter no máximo 30 caracteres");
                 }
                 familia = value;
             }
         }

         public string Cor
         {
             get
             {
                 return cor;
             }
             set
             {

                 if (string.IsNullOrEmpty(value))
                 {
                     throw new Exception("Cor deve ser preenchida");
                 }

                 if (value.Count() < 3)
                 {
                     throw new Exception("Cor deve conter no mínimo 4 caracteres");
                 }

                 if (value.Count() > 20)
                 {
                     throw new Exception("Cor deve conter no máximo 20 caracteres");
                 }
                 cor = value;
             }
         }



         public string CorAsa
         {
             get
             {
                 return corAsa;
             }
             set
             {

                 if (string.IsNullOrEmpty(value))
                 {
                     throw new Exception("Cor da asa deve ser preenchida");
                 }

                 if (value.Count() < 3)
                 {
                     throw new Exception("Cor da asa deve conter no mínimo 4 caracteres");
                 }

                 if (value.Count() > 20)
                 {
                     throw new Exception("Cor da asa deve conter no máximo 20 caracteres");
                 }
                 corAsa = value;
             }
         }



         public int TamanhoAsa
         {
             get
             {
                 return tamanhoAsa;
             }
             set
             {

                 if (value <= 0)
                 {
                     throw new Exception("Tamanho deve ser preenchido");
                 }

                 if (value < 3)
                 {
                     throw new Exception("Tamanho deve ser de no mínimo 3 metros");
                 }

                 if (value > 20)
                 {
                     throw new Exception("Tamanho deve ser de no máximo 20 metros");
                 }
                 tamanhoAsa = value;
             }
         }


         public string Elemento
         {
             get
             {
                 return elemento;
             }
             set
             {

                 if (string.IsNullOrEmpty(value))
                 {
                     throw new Exception("Elemento deve ser preenchido");
                 }

                 if (value.Count() < 3)
                 {
                     throw new Exception("Elemento deve conter no mínimo 4 caracteres");
                 }

                 if (value.Count() > 20)
                 {
                     throw new Exception("Elemento deve conter no máximo 20 caracteres");
                 }
                 elemento = value;
             }
         }

         

    }
}
