namespace Primeiro_Projeto_CSharp_CalculosMatematicosSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis para realização dos calculos
            double soma1;
            double soma2;
            double resultado;

            //Recebendo valores informados pelo usuário na interface da aplicação

            soma1 = double.Parse(textBox1.Text); // Recebe valor referente a textBox1 do formulário e converte uma informação tipo Texto para Double, pois a variavel é do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            soma2 = double.Parse(textBox2.Text); // Recebe valor referente a textBox2 do formulário e converte uma informação tipo Texto para Double, pois a variavel é do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            //Efetuando o calculo de Adição
            resultado = soma1 + soma2; //Executa o Calculo

            //Mostrar o resultado ao usuário
            textBox3.Text = resultado.ToString(); //Converte o valor da variavel do tipo double, para texto e assim será possivel retornar o valor dentro uma textBox.

            //Mostrar a operação matemática executada dentro da Label
            label5.Text = " + ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis para realização dos calculos
            double subtrai1;
            double subtrai2;
            double resultado;

            //Recebendo valores informados pelo usuário na interface da aplicação

            subtrai1 = double.Parse(textBox1.Text); // Recebe valor referente a textBox1 do formulário e converte uma informação tipo Texto para Double, pois a variavel é do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            subtrai2 = double.Parse(textBox2.Text); // Recebe valor referente a textBox2 do formulário e converte uma informação tipo Texto para Double, pois a variavel é do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            //Efetuando o calculo de Adição
            resultado = subtrai1 - subtrai2; //Executa o Calculo

            //Mostrar o resultado ao usuário
            textBox3.Text = resultado.ToString(); //Converte o valor da variavel do tipo double, para texto e assim será possivel retornar o valor dentro uma textBox.

            //Mostrar a operação matemática executada dentro da Label
            label5.Text = " - ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis para realização dos calculos
            double mult1;
            double mult2;
            double resultado;

            //Recebendo valores informados pelo usuário na interface da aplicação

            mult1 = double.Parse(textBox1.Text); // Recebe valor referente a textBox1 do formulário e converte uma informação tipo Texto para Double, pois a variavel é do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            mult2 = double.Parse(textBox2.Text); // Recebe valor referente a textBox2 do formulário e converte uma informação tipo Texto para Double, pois a variavel é do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            //Efetuando o calculo de Adição
            resultado = mult1 * mult2; //Executa o Calculo

            //Mostrar o resultado ao usuário
            textBox3.Text = resultado.ToString(); //Converte o valor da variavel do tipo double, para texto e assim será possivel retornar o valor dentro uma textBox.

            //Mostrar a operação matemática executada dentro da Label
            label5.Text = " * ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis para realização dos calculos
            double div1;
            double div2;
            double resultado;

            //Recebendo valores informados pelo usuário na interface da aplicação

            div1 = double.Parse(textBox1.Text); // Recebe valor referente a textBox1 do formulário e converte uma informação tipo Texto para Double, pois a variavel é do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            div2 = double.Parse(textBox2.Text); // Recebe valor referente a textBox2 do formulário e converte uma informação tipo Texto para Double, pois a variavel é do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            //Efetuando o calculo de Adição
            resultado = div1 / div2; //Executa o Calculo

            //Mostrar o resultado ao usuário
            textBox3.Text = resultado.ToString(); //Converte o valor da variavel do tipo double, para texto e assim será possivel retornar o valor dentro uma textBox.

            //Mostrar a operação matemática executada dentro da Label
            label5.Text = " / ";
        }
    }
}