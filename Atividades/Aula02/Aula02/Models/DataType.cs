namespace Aula02.Models
{
    public class DataType
    {
        public char myVar = 'a'; //um caracter aspas simples
        public char myConst = 'b';

        public char myChar1 = 'f';
        public char myChar2 = ':';
        public char myChar3 = 'x';

        //Podemos também atribuir referencia de caracteres Unicode 
        public char myChar4 = '\u2726';

        //Podemos ainda mesclar caracteres especiais com, nova linha, tabulação etc.
        public string textLine = "Esta é uma linha de texto.\n\n\nE esta é outra linha";

        /*
        \e Caracter de escape 
        \n Nova linha 
        \r Retono
        \t Tabulação horizontal
        \" Aspas duplas, usadas para exibir aspas dentro da string
        \' Aspas simples, usada para exibir aspas simples na string
         */

        //Interpolação de strings 
        //Combinando strings de diferentes maneiras no C#
        private int count = 10;
        public string message;
        

        public DataType()
        {
            //Interpolação de strings 
            //Combinando strings de diferentes maneiras no C#
            message = $"O contador está em {count}";

            string username = "Mateus";
            int inboxCount = 10;
            int maxCount = 100;

            message += $"\nO usuario {username} tem {inboxCount} mensagens";
            message += $"\nEspaço restante em sua caixa {maxCount - inboxCount}";
        }
    }
}
