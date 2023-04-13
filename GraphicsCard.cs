using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L3_Containment_Aggregation
{
    public class GraphicsCard
    {
        public enum Brand { Nvidia, AMD, Intel }

        Brand _graphicsCardBrand;

        public GraphicsCard(Brand graphicsCardBrand)
        {
            _graphicsCardBrand = graphicsCardBrand;
        }
    }
}
