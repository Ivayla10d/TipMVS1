using FirstMVS.Model;
using FirstMVS.View;

namespace FirstMVS.Controlles
{

    public class TipController
    {
        private Tip tip=new Tip();
        private Display display = new Display();

        public TipController()
        {
            //display = new Display();
            display.Input();
            tip.Amount = display.Amount;
            tip.Percent = display.Precent;
            display.Tip = tip.CalculateTip();
            display.Total = tip.CalcolateTotal();

            display.Output();
            
        }
    }
}
