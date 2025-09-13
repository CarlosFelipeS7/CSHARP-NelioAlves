using Herança.Entities;
using System;

namespace Herança
/* Para entender upcasting:
       PetShop com reserva de atendimento:
           1 Usuario cadastra seu cachorro com nome, especie, tamanho
           2 É adicionado a uma lista generica AnimaisConsulta(classe)           
           3 Veterinario recebe varios animais sem se preocupar

       basicamente nao importa ser cachorro ou gato, ele fica na lista de Animais a serem atendidos
       */

/* Para entender downcasting:
    4 Agora o veterinario precisa ver o tipo do animal, para pegar remedios
    5 Ele clica na lista de animais, e ve os detalhes: tamanho, cor, latir()

 agora importa transformar em subclasse
 */

/*Animal animalGenerico = new Cachorro();

Animal é a Classe Pai
animalGenerico é a variavel que referencia o objeto(atraves dela consulta tudo, metodos e atributos)
new Cachorro é o objeto alocado na memoria

 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando objetos
            Account contaNormal = new Account(1000, "Alex", 0.0);
 
            BusinessAccount contaEmpresa = new BusinessAccount(1002, "Maria", 0.0, 500);

            //UPCASTING 
            //aqui eu to criando uma variavel contExemploNormal do tipo Account(classe generica) e ela vai fazer referencia ao objeto contaEmpresa 
            Account contaExemploNormal = contaEmpresa; //uma aplicacao pratica disso seria uma lista de todas as contas em que nao importa o tipo, ai faco o Upcasting para cadastrar de forma generica

            //Armazenando objeto instanciado agora na variavel de classe generica criada agora
            Account variavelRefObjeto = new BusinessAccount(1003, "Bob", 0.0, 200);

            //DOWNCASTING

            //aqui eu to dizendo o seguinte:
            //a  variavel BusinessAccount variavelDown ira receber um cast da variavelRefObjeto
            //ou seja as duas referenciarão o mesmo objeto "bob" na memoria

            //entao tera uma variavel businessaccount para o objeto bob e uma account(generica) 
            //podendo escolher se vai usar de forma mais generica ou especifica
            BusinessAccount variavelDown = (BusinessAccount)variavelRefObjeto;

            variavelDown.Loan(100);


            
            if (contaNormal is BusinessAccount)
            {
                contaEmpresa = (BusinessAccount)contaNormal; 
                contaEmpresa.Loan(100); 
                Console.WriteLine("Empréstimo realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Não é possível realizar o empréstimo, não é BusinessAccount.");
            }
        }
    }
}
