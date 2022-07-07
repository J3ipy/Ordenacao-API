using Microsoft.AspNetCore.Mvc;
using  OrdenacaoAPI.Models;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersOrdersController : ControllerBase
    {
        [HttpGet]
        [Route("change")]
        public int[] change(int number1, int number2){
            NumberOrders numbers = new NumberOrders();

            return numbers.Change(number1, number2);

        }

        [HttpGet]
        [Route("Menos")]
        public int Menos(int number){
            NumberOrders numbers = new NumberOrders();

            return numbers.Menos(number);

        }
    }
}