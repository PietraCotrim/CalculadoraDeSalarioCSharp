🧮 Calculadora de Salário em C#

Este projeto é uma calculadora de salário desenvolvida em C#, executada no console, que realiza o cálculo de salário bruto e líquido, considerando diversos fatores trabalhistas brasileiros, como:

Hora extra

Adicionais

DSR

INSS

IRF

FGTS

Pensão

Dependentes

📌 Funcionalidades

A aplicação solicita informações ao usuário e realiza os seguintes cálculos:

Salário base (valor da hora × horas trabalhadas)

Hora extra com percentual personalizado

Adicionais (ex: adicional noturno)

DSR (Descanso Semanal Remunerado)

INSS (cálculo progressivo por faixa)

FGTS (8% sobre o salário bruto)

IRF (Imposto de Renda na Fonte)

Dedução simplificada

Dedução por dependentes

Desconto de pensão alimentícia

Cálculo do salário líquido

🛠️ Ferramentas Utilizadas

C#

.NET Console Application

System.Globalization

▶️ Como Executar

Ter o .NET SDK instalado na máquina:

https://dotnet.microsoft.com/download

Clonar o repositório no terminal:

git clone https://github.com/PietraCotrim/CalculadoraDeSalarioCSharp.git

Abrir a pasta do projeto:

cd CalculadoraDeSalarioCSharp

Executar o projeto:

dotnet run

🧾 O sistema solicitará as seguintes informações:

Valor da hora trabalhada

Quantidade de horas trabalhadas

Existência de adicional (%)

Existência de hora extra

Quantidade de horas extras

Percentual da hora extra

Desconto de pensão (valor fixo)

Quantidade de dependentes

Regime de trabalho:

Horista

Mensalista

Tipo de dedução do IRF:

Simplificada

Por dependentes
