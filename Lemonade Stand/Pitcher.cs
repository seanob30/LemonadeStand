using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Pitcher
    {
        public void CreatePitchers(Player player)
        {
            player.SubtractLemons(player.playerRecipe.ingredientLemon);
            player.SubtractSugar(player.playerRecipe.ingredientSugar);
            player.SubtractIce(player.playerRecipe.ingredientIce);
        }

    }
}
