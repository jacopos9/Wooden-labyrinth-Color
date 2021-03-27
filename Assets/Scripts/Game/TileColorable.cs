using UnityEngine;
using jsFramework;

namespace jsFramework
{
    public interface Icolorable
    {
        /*
        float red { get; set; }
        float blue { get; set; }
        float green { get; set;}
        */
        void ColorChange(Color color);
    }
}