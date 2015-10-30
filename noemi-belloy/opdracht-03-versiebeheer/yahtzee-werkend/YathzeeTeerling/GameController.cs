using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
    class GameController
    {
        private GameView view;
        private YathzeeController yahtzee;
        private ScoreboardController scoreboard;

        public GameController()
        {
            
            view = new GameView(this);
            yahtzee = new YathzeeController(this);

            /*
                Configureer het maximum aantal worpen die mogelijk zijn in één spelletje
            */
            yahtzee.MaximumAantalWorpen = 5;
            yahtzee.AantalTeerlingen = 3;

            /*
                Initializeer de yahtzeecontroller
                Dit betekent de controller uitvoeren met de net toegewezen variabelen (=MaximumAantalWorpen)
            */
            yahtzee.initialize();

            /*
                Maak een instantie aan van het scoreboard en injecteer de huidige context
            */
            scoreboard = new ScoreboardController(this);
        }

        /*
        
            Deze methode wordt aangesproken van zodra er een verandering heeft plaatsgevonden
            in het scoreboard of de yahtzee instantie
        */
        public void modelHasChanged()
        {
            scoreboard.updateView();
        }

        /*
            Deze methode returnt de view voor het volledige spel
        */
        public GameView getView()
        {
            return view;
        }

        /*
            Deze methode returnt de User Control view voor Yahtzee
        */
        public YahtzeeView getViewYahtzee()
        {
            return yahtzee.getView();
        }

        /*
            Deze methode returnt de User Control view voor het Scoreboard
        */
        public ScoreboardView getViewScoreboard()
        {
            return scoreboard.getView();
        }

        /*
            Deze methode returnt het gedefinieerde maximum aantal worpen
        */
        public int MaximumAantalWorpen
        {
            get
            {
                return yahtzee.MaximumAantalWorpen;
            }
        }


        public int HuidigAantalWorpen
        {
            get
            {
                return yahtzee.HuidigAantalWorpen;
            }
        }
    }
}
}
