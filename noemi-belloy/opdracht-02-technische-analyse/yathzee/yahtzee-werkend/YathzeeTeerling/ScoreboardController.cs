using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
    class ScoreboardController
    {
        private GameController container;
        private ScoreboardView view;
        private ScoreboardModel model;

    }

    public ScoreboardController(GameController cont)
    {
        container = cont;
        view = new ScoreboardView(this);
        model = new ScoreboardModel();
    }
    
    public ScoreboardView getView()
    {
        return view;
    }
    

    
    public int HuidigAantalWorpen
    {
        get
        {
            return container.HuidigAantalWorpen;
        }
    }
    
    public void updateView()
    {
        view.updateView();
    }

}
}
