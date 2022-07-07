namespace OrdenacaoAPI.Models
{
    public class NumberOrders
    {
       public int[] Change(int number1, int number2){

        int temp  = number1;
        number1 = number2;
        number2 = temp;
        int[] numbers = new int[]{number1,number2};
        return numbers;

       }
        public int Menos(int number){
            if(number<0){
                return number;
            }else{
                return number * -1;
            }

       }
    }


}