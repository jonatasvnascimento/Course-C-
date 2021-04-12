using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Agenda
{
    public static class cl_geral
    {

        public static string version = "v 1.0.0";

        //lista de contatos do tipo contato
        public static List<cl_contacto> LISTA_CONTACTOS;

        public static void ConstroiListaContactos()
        {
            //metodo para carregar lista de contatos

            //verificar se o ficheiro existe
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contacto.txt";

            //Cria lista vazia de contatos
            LISTA_CONTACTOS = new List<cl_contacto>();

            if (File.Exists(nome_ficheiro))
            {
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                //Carregar tos ficheiros
                while (!ficheiro.EndOfStream)
                {

                    //Linha Nome
                    string nome = ficheiro.ReadLine();
                    //Linha Telefone
                    string numero = ficheiro.ReadLine();
                    //Linha CEP
                    string cep = ficheiro.ReadLine();
                    //Linha Email
                    string email = ficheiro.ReadLine();

                    //adiciona numero e nome ao lista de contatos e carrega os mesmo
                    cl_contacto novo_contacto = new cl_contacto();
                    novo_contacto.nome = nome;
                    novo_contacto.numero = numero;
                    novo_contacto.cep = cep;
                    novo_contacto.email = email;
                    LISTA_CONTACTOS.Add(novo_contacto);
                    
                }
                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegistro(string _nome, string _numero, string _cep, string _emal)
        {
            //gravar um novo registro na lista de ficheros

            //gravar na lista
            LISTA_CONTACTOS.Add(new cl_contacto()
            {
                nome = _nome,
                numero = _numero,
                cep = _cep,
                email = _emal
            });

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contacto.txt";

            StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false, Encoding.Default);
            foreach (cl_contacto contacto in LISTA_CONTACTOS)
            {
                ficheiro.WriteLine(contacto.nome);
                ficheiro.WriteLine(contacto.numero);
                ficheiro.WriteLine(contacto.cep);
                ficheiro.WriteLine(contacto.email);

            }
            ficheiro.Dispose();
        }
    }
}
