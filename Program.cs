using static System.Console; // Permite usar WriteLine diretamente
using System; // Biblioteca padrão
using System.Globalization;

namespace Calculadora
{
    public class Salario
    {
        static void Main(string[] args)
        {
            CultureInfo cultura = CultureInfo.InvariantCulture;
            WriteLine("");
            WriteLine("Olá, seja bem vindo(a)");
            WriteLine("Para que o calculo seja possivel, será necessario algumas informações:");
            WriteLine("");
            WriteLine("1) Qual o valor da sua hora?");
            double vrHora = double.Parse(ReadLine(), cultura);
            WriteLine("2) Quantas horas foram trabalhadas?");
            double qtdHoras = double.Parse(ReadLine(), cultura);
            double adicional = 0;
            WriteLine("3) Você recebe algum adicional? (sim/nao)"); 
            if (ReadLine().ToLower() == "sim")
            {
                WriteLine("Qual a porcentagem desse adicional?");
                adicional = double.Parse(ReadLine(), cultura);
            }
            double qtdExtra = 0;
            double porcentagem = 0;
            WriteLine("4) Foi feito hora extra? (sim/nao)");
            if (ReadLine().ToLower()=="sim")
            {
                WriteLine("Quantas horas extras foram trabalhadas?");
                qtdExtra = double.Parse(ReadLine(), cultura);
                WriteLine("Qual a porcentagem da sua hora extra? Ex:100, 50, 60 ...");
                porcentagem = double.Parse(ReadLine(), cultura);
            }
            double pensao = 0;
            WriteLine("5) Existe desconto de pensão?");
            if (ReadLine().ToLower() == "sim")
            {
                WriteLine("Qual o valor da pensão?");
                pensao = double.Parse(ReadLine(), cultura);
            }
            WriteLine("6) Quantos dependentes declarados?");
            int qtdDependentes = int.Parse(ReadLine());

            /*    Calculo Extra      */
            double extra = vrHora * (1 + porcentagem / 100) * qtdExtra;

            /*    Salario base      */
            double salarioBase = qtdHoras * vrHora;
            
            /*      Adicional        */
            double vrAdicional = salarioBase * adicional / 100;
            
            /*      DSR              */
            double DSR = 0;
            WriteLine("7)Qual o regime? (Horista/Mensalista)");
            string regime = ReadLine().ToLower();
            if (regime == "horista")
            {
                DSR = (salarioBase + extra + vrAdicional) / 26 * 4;
            }
            else if (regime == "mensalista" && extra > 0)
            {
                DSR = (extra) / 26 * 4; /* Já que o mensalista ja tem o valor incluso*/
            }
            
            /*    Salario bruto      */
            double Bruto = salarioBase + extra + vrAdicional + DSR;
            
            /*        INSS           */
            double INSS = 0;
            
            if (Bruto <= 1412.00 )
            {
                INSS = Bruto * 0.075;
            }
            else if (Bruto <= 2666.68)
            {
                INSS = (1412.00 * 0.075) + ((Bruto-1412.00) * 0.09);
            }
            else if (Bruto <= 4000.03)
            {
                INSS = (1412.00 * 0.075) + ((2666.68 - 1412.00) * 0.09) + ((Bruto - 2666.68) * 0.12);
            }
            else if (Bruto <= 7786.02)
            {
                INSS = (1412.00 * 0.075) + ((2666.68 - 1412.00) * 0.09) + ((4000.03 - 2666.68) * 0.12) + ((Bruto - 4000.03) * 0.14);
            }
            else
            {
                INSS = (1412.00 * 0.075) + ((2666.68 - 1412.00) * 0.09) + ((4000.03 - 2666.68) * 0.12) + ((7786.02 - 4000.03) * 0.14);
            }

            /*        FGTS           */
            double FGTS = Bruto * 8 / 100;
            
            /*         IRF           */
            double BaseIRF = 0;
            WriteLine("No IRF a dedução é feita de forma simplificada ou por dependentes?");
            if(ReadLine().ToLower() == "simplificada")
            {
                BaseIRF = Bruto - INSS - 528.00 - pensao;
            }
            else 
            {
                BaseIRF = Bruto - INSS - (qtdDependentes * 189.59) - pensao;
            }
               
            if (BaseIRF < 0)
                BaseIRF = 0;

            double IRF = 0;
            if (BaseIRF <= 2259.20)
            {
                IRF = 0;
            }
            else if (BaseIRF <= 2826.65)
            {
                IRF = (BaseIRF - 2259.20) * 0.075;
            }
            else if (BaseIRF <= 3751.05)
            {
                IRF = (2826.65 - 2259.20) * 0.075 +((BaseIRF-2826.65)*0.15) ;
            }
            else if (BaseIRF <= 4664.68)
            {
                IRF = (2826.65 - 2259.20) * 0.075 + ((3751.05 - 2826.65) * 0.15) + ((BaseIRF - 3751.05)*0.225);
            }
            else
            {
                IRF = (2826.65 - 2259.20) * 0.075 + ((3751.05 - 2826.65) * 0.15) + ((4664.68 - 3751.05) * 0.225) + ((BaseIRF - 4664.68)* 0.275);
            }
            
            /*      Liquido          */
            double liquido = Bruto - INSS - IRF - pensao;
            double adiantamento = liquido * 40 / 100;
            double pagamento = liquido * 60 / 100;

            /*      Retorno          */
            WriteLine("");
            WriteLine($"Salario base: {salarioBase}");
            WriteLine($"Salario bruto: {Bruto}");
            WriteLine($"Salario liquido:{liquido}");
            WriteLine("");
            WriteLine($"Hora extra: {extra}");
            WriteLine($"Adicional(is): {vrAdicional}");
            WriteLine("");
            WriteLine($"Base de calculo do INSS:{Bruto}");
            WriteLine($"INSS: {INSS}");
            WriteLine($"Base de calculo do IRF:{BaseIRF}");
            WriteLine($"FGTS:{FGTS}");
            WriteLine($"IRF: {IRF}");
            WriteLine("");
            WriteLine($"Adiantamento de salario:{adiantamento}");
            WriteLine($"Paagamento:{pagamento}");




        }

    } 
}
