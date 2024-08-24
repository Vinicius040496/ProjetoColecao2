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
/*

** RESUMO FSX

O Amazon FSx é um serviço de armazenamento de arquivos totalmente gerenciado da AWS.
que facilita o lançamento e a execução de sistemas de arquivos de terceiros.
O FSx fornece o rico conjunto de recursos e a rápida performance que esses tipos de aplicativos precisam, e atualmente suporta dois sistemas de arquivos: Windows File Server para aplicações baseadas em Windows, e Lustre para cargas de trabalho de computação intensiva.

Aqui estão alguns pontos chave sobre o Amazon FSx:

FSx para Windows File Server: Ele fornece um sistema de arquivos nativamente compatível com o Windows.
permitindo que você mova com facilidade as aplicações baseadas em Windows que exigem o sistema de arquivos do Windows para a AWS.
É construído sobre o Windows Server e oferece suporte a recursos como deduplicação de dados, criptografia de dados em repouso, e acesso via SMB (Server Message Block) e NFS (Network File System).

FSx para Lustre: O Lustre é um sistema de arquivos popular para cargas de trabalho de computação intensiva. 
como análise de big data, modelagem de machine learning e processamento de mídia. O FSx para Lustre é totalmente gerenciado pela AWS, simplificando o processo de criação e execução de um sistema de arquivos Lustre.

Desempenho: O Amazon FSx foi projetado para oferecer o desempenho rápido necessário para suportar aplicações exigentes.
Ele fornece baixa latência e altas taxas de transferência de dados.

Compatibilidade e Integração: O Amazon FSx é totalmente compatível com os sistemas de arquivos que suporta.
o que significa que você pode usar suas ferramentas e aplicações existentes sem modificação. Além disso, o FSx se integra com uma série de outros serviços AWS.
para coisas como backup, monitoramento e acesso seguro a arquivos.

Segurança: O Amazon FSx oferece várias funcionalidades de segurança, como a capacidade de armazenar dados em redes virtuais privadas da Amazon (VPCs).
suporte a redes de acesso (ACLs) para o Windows File Server, criptografia de dados em repouso e em trânsito, e integração com AWS Key Management Service (KMS) para gerenciamento de chaves de criptografia.

Em resumo, o Amazon FSx é um serviço poderoso e flexível que torna mais fácil do que nunca para você executar sistemas de arquivos totalmente gerenciados na AWS.
Ele suporta sistemas de arquivos Windows e Lustre, oferecendo um alto nível de desempenho, segurança e integração com outros serviços AWS.


*/
