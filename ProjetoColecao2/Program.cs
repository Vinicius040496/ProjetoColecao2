using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoColecao2.Entites;

namespace ProjetoColecao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<Studant> set = new HashSet<Studant>();
                Console.Write("Quantos alunos matriculados no curso A: ");
                int N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("Digite ID: ");
                    int id = int.Parse(Console.ReadLine());
                    set.Add(new Studant(id));
                    Console.WriteLine();
                }
                Console.Write("Quantos alunos matriculados no curso B: ");
                N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("Digite ID: ");
                    int id = int.Parse(Console.ReadLine());
                    set.Add(new Studant(id));
                    Console.WriteLine();
                }
                Console.Write("Quantos alunos matriculados no curso C: ");
                N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("Digite ID: ");
                    int id = int.Parse(Console.ReadLine());
                    set.Add(new Studant(id));
                    Console.WriteLine();
                }
                Console.WriteLine("Total de estudante matriculados nos cursos: " + set.Count);
              
            }
            catch (StudantException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
1- quais tipos de sistemas operacionais existentes ?

Existem diversos tipos de sistemas operacionais, cada um projetado para atender a diferentes necessidades e ambientes.
Sistemas Operacionais de Desktop:

Windows
macOS
Linux: Diversas distribuições, como Ubuntu, Fedora e Debian,etc.

Sistemas Operacionais Móveis:

Android:
iOS
Windows Mobile

Sistemas Operacionais de Servidor:

Windows Server

Linux Server
Unix

Sistemas Operacionais em Tempo Real (RTOS):

Utilizados em sistemas que requerem resposta rápida, como em automação industrial e sistemas embarcados

Sistemas Operacionais para Mainframes:

z/OS: Usado em mainframes IBM.
VMS: Usado em sistemas da Digital Equipment Corporation.

Sistemas Operacionais de Rede:

Focados em gerenciar redes, como o Novell NetWare.

Sistemas Operacionais Embarcados:

2- por que se pode dizer que existem uma subutilização de recursos de sistemas monoprogramaveis ? 

A subutilização de recursos em sistemas monoprogramáveis ocorre porque esses sistemas executam apenas um único processo por vez, o que leva a várias ineficiências. Aqui estão alguns motivos:

Ociosidade da CPU: Quando um processo está aguardando por entrada/saída (E/S)

Tempo de Espera: O tempo que um processo passa aguardando por recursos (como memória ou E/S) não é utilizado efetivamente, levando a um uso ineficiente da capacidade do sistema.

Recursos Ociosos: Outros recursos do sistema, como memória e dispositivos periféricos, podem estar subutilizados enquanto um único processo é executado.

Escalabilidade Limitada: A capacidade de escalar o sistema e atender a mais usuários ou processos é restrita, já que apenas um processo pode ser executado por vez.

3- qual a grande diferença entre sistemas monoprogramaveis e sistemas multiprogramaveis ?

 diferença entre sistemas monoprogramáveis e multiprogramáveis reside na forma como eles gerenciam a execução de processos.
 sistemas multiprogramáveis maximizam o uso dos recursos ao permitir a execução simultânea de múltiplos processos, enquanto sistemas monoprogramáveis executam apenas um processo por vez, resultando em menor eficiência.

 4- quais vantagens dos sistemas multiprogramaveis ?

 Execução de múltiplos processos: Vários processos são carregados na memória e podem ser executados de forma intercalada. O sistema operacional gerencia a alternância entre eles.

Uso mais eficiente da CPU: Enquanto um processo está aguardando E/S, outro pode ser executado, minimizando o tempo ocioso da CPU e aumentando a eficiência do sistema.

Complexidade na gestão: O sistema operacional precisa implementar técnicas de escalonamento e gerenciamento de memória para lidar com múltiplos processos, tornando o sistema mais complexo.

5- quais são os tipos de sistemas multiprogramaveis ?

Sistemas de Tempo Compartilhado:
Permitem que múltiplos usuários interajam com o sistema simultaneamente.

Sistemas em Lote:
Executam um conjunto de tarefas de forma sequencial sem interação do usuário durante a execução

Sistemas de Tempo Real:
Projetados para processar dados em tempo real e garantir que as tarefas sejam concluídas dentro de prazos específicos.

Sistemas de Rede:
Gerenciam recursos e processos distribuídos em uma rede de computadores.

Sistemas Baseados em Microkernel:
Utilizam um microkernel para gerenciar apenas funções essenciais

6- como funcionam os sistemas de tempo compartilhado ?

Os sistemas de tempo compartilhado funcionam permitindo que múltiplos usuários ou processos utilizem um mesmo sistema computacional simultaneamente, criando a impressão de que cada um possui acesso exclusivo à CPU.

principais pontos:
Divisão do Tempo da CPU.
Escalonamento de Processos:
Gerenciamento de Memória
Gerenciamento de Recursos:

7- quais componentes de um processador e quais são suas funçoes ?

Unidade de Controle (UC):
Função: Coordena as atividades do processador, gerenciando a execução de instruções e controlando o fluxo de dados entre os componentes do sistema.

2. Unidade Lógica e Aritmética (ULA):
Função: Realiza operações aritméticas (como soma e subtração) e lógicas (como comparação e operações booleanas). É responsável por todas as operações matemáticas do processador.

3. Registradores:
Função: Pequenas unidades de armazenamento de alta velocidade dentro do processador, usadas para armazenar dados temporários e instruções durante a execução de programas. Exemplos incluem o registrador acumulador e registradores de instrução.

4. Cache:

Função: Memória de acesso rápido que armazena cópias de dados e instruções frequentemente usados, reduzindo o tempo de acesso à memória principal. O cache é dividido em níveis (L1, L2, L3) com diferentes velocidades e tamanhos.
5. Barramento:
Função: Conjunto de linhas de comunicação que permite a transferência de dados entre o processador, a memória e outros componentes do sistema. Inclui barramentos de dados, endereços e controle.

6. Unidade de Pontos Flutuantes (FPU):
Função: Especializada em operações com números de ponto flutuante (números reais), permitindo cálculos mais complexos com maior precisão.

7. Controladores de Entrada/Saída (I/O):
Função: Gerenciam a comunicação entre o processador e dispositivos de entrada/saída, como teclados, mouses, discos rígidos e impressoras.

8. Unidade de Previsão de Desvio:
Função: Acelera o fluxo de instruções

8- como a memoria principal de um computador é organizada ? 

Hierarquia da Memória:
A memória é organizada em uma hierarquia, que inclui níveis de memória com diferentes velocidades e capacidades.

Endereçamento:
A memória é dividida em endereços, que são usados pelo processador para acessar dados. Cada unidade de dados (como um byte) tem um endereço único

Divisão em Células:
A memória é composta por células de memória, onde cada célula armazena um conjunto fixo de bits (geralmente 8 bits ou 1 byte). Essas células são organizadas em linhas e colunas, formando uma matriz.

Memória Volátil e Não Volátil:
A memória principal (como a RAM) é geralmente volátil.
Já a memória não volátil (como ROM) retém os dados mesmo sem energia.

Paginamento e Segmentação:
Para gerenciar a alocação de memória, sistemas operacionais utilizam técnicas como paginamento e segmentação. 

Cache:
A memória cache, que está entre o processador e a memória principal

9- descreva os ciclos de leitura e gravação da memoria principal ?

Ciclo de Leitura
Início do Ciclo:

O processador envia um endereço para a memória, indicando qual dado ele deseja ler.
Decodificação do Endereço:

A memória decodifica o endereço e localiza a célula correspondente onde o dado está armazenado.
Acesso ao Dado:

A célula de memória é acessada, e o dado é recuperado.
Transmissão do Dado:

O dado é enviado de volta para o processador através do barramento de dados.
Finalização do Ciclo:

O processador recebe o dado e continua sua operação.
Ciclo de Gravação
Início do Ciclo:

O processador prepara o endereço onde deseja gravar os dados e coloca os dados a serem gravados no barramento de dados.
Decodificação do Endereço:

Assim como no ciclo de leitura, o endereço é decodificado para localizar a célula de memória onde os dados serão gravados.
Acesso à Célula:

A célula de memória correspondente é acessada, e o sistema se prepara para a gravação.
Gravação do Dado:

Os dados do barramento de dados são gravados na célula de memória.
Finalização do Ciclo:

10 - o que são memorias volateis e não volateis ?

Memórias Voláteis
Definição: Memórias voláteis são aquelas que perdem seu conteúdo quando a energia é desligada. Elas são usadas para armazenamento temporário de dados que o processador precisa acessar rapidamente.

Memórias Não Voláteis
Definição: Memórias não voláteis mantêm seu conteúdo mesmo quando a energia é desligada. Elas são usadas para armazenar dados a longo prazo.
