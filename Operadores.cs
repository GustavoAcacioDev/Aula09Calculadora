namespace Aula09Calculadora
{
    public class Operadores
    {
        
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int Somar(){
        
            return num1 + num2;
        }

        public int Subtrair(){
            return num1 - num2;
        }

        public int Multiplicar(){
            return num1 * num2;
        }

        public int Dividir(){
            return num1 / num2;
        }
    }
}