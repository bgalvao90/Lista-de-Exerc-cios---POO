using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Exercício_Criando_um_sistema_de_Conta_Bancária
{
    internal class ContaBancaria
    {
        public string NumeroConta;
        public string Titular;
        public double Saldo;



        public override string ToString()
        {
            return $" Número da conta: {NumeroConta}                     Nome do Titular: {Titular}";
        }
        public void Depositar(double valor)
        {
            
                Saldo += valor;
            }
        public void Sacar(double valor)
            {
                Saldo -= valor;
            }
        public void ExibirSaldo()
            {
                Console.WriteLine("Saldo: " + Saldo + " R$");
            }
        }
    }


