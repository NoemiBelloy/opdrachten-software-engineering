using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YathzeeTeerling
{
    // controller op public zodat view die controller als argument kan meekrijgen
    public class TeerlingController
    {
        // Member die view controller en model gaan onthouden 
        private TeerlingView _view;
        private YahtzeeController _controllerYahtzee;
        public TeerlingModel _model;

        //belangrijk, anders is random getal altijd zelfde
        //seeder moet zelf ook random zijn anders krijg je elke keer je opnieuw opstart dezelfde getallen
        static int seeder = new Random().Next();

        //random getal maken
        Random random = new Random(++seeder);


        //constructor aanmaken
        public TeerlingController(YahtzeeController controller )
        {
            //instantie van de view met huidige instantie als argument
            _view = new TeerlingView(this); 
        
            //instantie van model                                     
            _model = new TeerlingModel();

            _controllerYahtzee = controller;
        }

        public TeerlingView getView()
        {
            //return huidige view
            return _view;
        }
        //methode om teerling te werpen

        public void werpTeerling()
        {
            YahtzeeModel _modelYahtzee = _controllerYahtzee.getModel();
            if (!_model.Vast && _modelYahtzee.AantalWorpen <= _modelYahtzee.MaxAantalWorpen)
            {
                int teerlingGetal = random.Next(1, 7); //random tussen 1 en 6
                _model.Aantalogen = teerlingGetal; //random getal doorsturen naar model
            }
        }

        public void toggleVast()
        {
            _model.Vast = !_model.Vast;
        }

        public void resetTeerling()
        {
            _model.Aantalogen = 0;
            _model.Vast = false;
            _view.updateUI();
        }
    }
}
