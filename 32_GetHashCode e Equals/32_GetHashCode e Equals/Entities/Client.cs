using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_GetHashCode_e_Equals.Entities
{
     class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

    
   public override bool Equals(object obj) //por padrao o parametro do equals é object
        {
            if(!(obj is Client)) // is aqui olha se o OBJETO atrelado a variavel obj é um client ou nao
            {
                return false;
            
            }
            
            //Se a variavel obj estiver referenciando um objeto cliente,
            //a variavel Client outro passara a apontar o mesmo objeto
            Client outro = obj as Client;

            return Email.Equals(outro.Email);
           
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
       
    }
}
