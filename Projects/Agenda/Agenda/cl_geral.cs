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

        public static void ControiListaContatos()
        {
            //metodo para carregar lista de contatos

            //verificar se o ficheiro existe
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contacto.txt";
            if (File.Exists(nome_ficheiro))
            {

            }
        }
    }
}
