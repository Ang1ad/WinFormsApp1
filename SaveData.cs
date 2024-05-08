using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable()]
    public class SaveData
    {
        public Size size;
        public List<Figure> arrayOfFigures;

        public SaveData(Size size, List<Figure> arrayOfFigures)
        {

            this.size = size;
            this.arrayOfFigures = arrayOfFigures;
        }
    }
}
