# CalculadoraDeSalario em Csharp
Este projeto é uma calculadora de salário desenvolvida em C#, executada no console, que realiza o
cálculo de salário bruto e líquido considerando diversos fatores trabalhistas brasileiros, como hora 
extra, adicionais, DSR, INSS, IRF, FGTS, pensão e dependentes.

#Funcionalidades
A aplicação solicita informações ao usuário e realiza os seguintes cálculos:
1.Salário base (valor da hora × horas trabalhadas)
2.Hora extra com percentual personalizado
3.Adicionais (ex: adicional noturno)
4.DSR (Descanso Semanal Remunerado)
5.INSS (cálculo progressivo por faixa)
6.FGTS (8% sobre o salário bruto)
7.IRF (Imposto de Renda na Fonte)
  .Dedução simplificada
  .Dedução por dependentes
8.Desconto de pensão alimentícia
9.Cálculo do salário líquido

#Ferramentas utilizadas
1.C#
2.DotNET Console Application
3.System.Globalization

#Como executar
1.Ter o .Net SDK instalado na maquina
https://dotnet.microsoft.com/download
2.Clonar o repositorio no terminal
git clone https://github.com/PietraCotrim/CalculadoraDeSalarioCSharp.git
3.Abrir a pasta do projeto
cd CalculadoraDeSalarioCSharp
4.Executar o projeto
dotnet run

#O sistema solicitará as seguintes informações:
1.Valor da hora trabalhada
2.Quantidade de horas trabalhadas
3.Existência de adicional (%)
4.Existência de hora extra
  .Quantidade de horas extras
  .Percentual da hora extra
5.Desconto de pensão (valor fixo)
6.Quantidade de dependentes
7.Regime de trabalho:
  .Horista
  .Mensalista
8.Tipo de dedução do IRF:
  .Simplificada
  .Por dependentes
