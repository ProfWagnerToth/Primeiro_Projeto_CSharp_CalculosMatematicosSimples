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
            //Declara��o de Vari�veis para realiza��o dos calculos
            double soma1;
            double soma2;
            double resultado;

            //Recebendo valores informados pelo usu�rio na interface da aplica��o

            soma1 = double.Parse(textBox1.Text); // Recebe valor referente a textBox1 do formul�rio e converte uma informa��o tipo Texto para Double, pois a variavel � do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            soma2 = double.Parse(textBox2.Text); // Recebe valor referente a textBox2 do formul�rio e converte uma informa��o tipo Texto para Double, pois a variavel � do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            //Efetuando o calculo de Adi��o
            resultado = soma1 + soma2; //Executa o Calculo

            //Mostrar o resultado ao usu�rio
            textBox3.Text = resultado.ToString(); //Converte o valor da variavel do tipo double, para texto e assim ser� possivel retornar o valor dentro uma textBox.

            //Mostrar a opera��o matem�tica executada dentro da Label
            label5.Text = " + ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Declara��o de Vari�veis para realiza��o dos calculos
            double subtrai1;
            double subtrai2;
            double resultado;

            //Recebendo valores informados pelo usu�rio na interface da aplica��o

            subtrai1 = double.Parse(textBox1.Text); // Recebe valor referente a textBox1 do formul�rio e converte uma informa��o tipo Texto para Double, pois a variavel � do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            subtrai2 = double.Parse(textBox2.Text); // Recebe valor referente a textBox2 do formul�rio e converte uma informa��o tipo Texto para Double, pois a variavel � do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            //Efetuando o calculo de Adi��o
            resultado = subtrai1 - subtrai2; //Executa o Calculo

            //Mostrar o resultado ao usu�rio
            textBox3.Text = resultado.ToString(); //Converte o valor da variavel do tipo double, para texto e assim ser� possivel retornar o valor dentro uma textBox.

            //Mostrar a opera��o matem�tica executada dentro da Label
            label5.Text = " - ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Declara��o de Vari�veis para realiza��o dos calculos
            double mult1;
            double mult2;
            double resultado;

            //Recebendo valores informados pelo usu�rio na interface da aplica��o

            mult1 = double.Parse(textBox1.Text); // Recebe valor referente a textBox1 do formul�rio e converte uma informa��o tipo Texto para Double, pois a variavel � do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            mult2 = double.Parse(textBox2.Text); // Recebe valor referente a textBox2 do formul�rio e converte uma informa��o tipo Texto para Double, pois a variavel � do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            //Efetuando o calculo de Adi��o
            resultado = mult1 * mult2; //Executa o Calculo

            //Mostrar o resultado ao usu�rio
            textBox3.Text = resultado.ToString(); //Converte o valor da variavel do tipo double, para texto e assim ser� possivel retornar o valor dentro uma textBox.

            //Mostrar a opera��o matem�tica executada dentro da Label
            label5.Text = " * ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Declara��o de Vari�veis para realiza��o dos calculos
            double div1;
            double div2;
            double resultado;

            //Recebendo valores informados pelo usu�rio na interface da aplica��o

            div1 = double.Parse(textBox1.Text); // Recebe valor referente a textBox1 do formul�rio e converte uma informa��o tipo Texto para Double, pois a variavel � do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            div2 = double.Parse(textBox2.Text); // Recebe valor referente a textBox2 do formul�rio e converte uma informa��o tipo Texto para Double, pois a variavel � do tipo double, ou seja, pode receber numeros (Inteiros, Fracionados, Positivos ou Negativos)

            //Efetuando o calculo de Adi��o
            resultado = div1 / div2; //Executa o Calculo

            //Mostrar o resultado ao usu�rio
            textBox3.Text = resultado.ToString(); //Converte o valor da variavel do tipo double, para texto e assim ser� possivel retornar o valor dentro uma textBox.

            //Mostrar a opera��o matem�tica executada dentro da Label
            label5.Text = " / ";
        }
    }
}