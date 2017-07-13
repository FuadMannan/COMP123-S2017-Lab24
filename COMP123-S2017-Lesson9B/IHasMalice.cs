using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Fuad Mannan
 * Date: July 13, 2017
 * Description: This is the IHasMalice interface used in the SuperVillain class
 * Version: 0.2 - Added Malice property, changed interface scope to public
 */

namespace COMP123_S2017_Lesson9B
{
    public interface IHasMalice
    {
        //PUBLIC PROPERTIES
        int Malice { get; set; }
    }
}
