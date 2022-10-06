using System;
using System.IO;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        // Sistema que cria uma lista de alunos em um arquivo XML

        string arquivo = @"F:\2_AMS\Programmer's\Manipulacao_Arquivos\Manipulacao_XML\jeferson\GravarXML\xml\teste.xml"; //Variável com caminho do arquivo.
        int contador = 0;

        Console.Write("Digite o nome da turma: "); //Nome da lista
        string turma = Console.ReadLine();

        Console.Write("Digite a quantidade de alunos: "); //Quantidade de alunos da lista
        int quant = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(); //Pular Linha

        // ---------------------------------------------------------
       
        XmlTextWriter writer = new XmlTextWriter(arquivo, null); //Declara um TextWriter já indicando o arquivo XML

        
        writer.WriteStartDocument(); //Inicia a gravação do documento XML
        
        writer.Formatting = Formatting.Indented; //Define a indentação do arquivo XML
        
        writer.WriteStartElement(turma.ToUpper().Replace(" ", "_")); //Escreve o elemento raiz
        
        while (contador != quant) //Laço While para inserir a quantidade de alunos na lista
        {
            contador++;
            
            Console.WriteLine($"Aluno {contador}) ");

            Console.Write("Digite o RM do aluno: "); // O usuário digita o RM do Aluno
            string id = Console.ReadLine();

            Console.Write("Digite o nome do aluno: "); // O usuário digita o Nome do Aluno
            string nome = Console.ReadLine();

            writer.WriteElementString(id, nome.ToUpper()); //Escreve os sub-elementos do elemento raiz
        }

        writer.WriteEndElement(); //Encerra o elemento raiz

        writer.Close(); //Escreve o XML para o arquivo e fecha o objeto escritor

        Console.WriteLine(); //Pular Linha

        Console.WriteLine("Itens inseridos com sucesso!");
    }
}
        
        
        
        
        
        
        
        
        // SEGUNDO MÉTODO --------------------------------------------------------------
        //XmlTextWriter gravar = new XmlTextWriter(arquivo, null);
        //gravar.WriteString(nome);
        //gravar.WriteValue();
        //gravar.Close();
