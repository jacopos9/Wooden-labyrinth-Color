﻿using UnityEngine;
using jsFramework;

namespace jsFramework
{
    /// <summary>
    /// gestisce il comportamento di una tile
    /// </summary>
    public class TileController : MonoBehaviour , Icolorable
    {
        Icolorable tile;

        public TileData TileData;
        public Color mycolor = Color.blue;

        /*
         public float red { get; set; } = 33;
         public float blue { get; set; }
         public float green { get; set; }
        */

        void Start()
        {
            tile = GetComponent<Icolorable>();
        }

        public void ColorChange(Color color)
        {
            color = Color.green; //c5e8eb;
            gameObject.GetComponentInChildren<Renderer>().material.color = color;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Ball")
            {
                tile.ColorChange(mycolor);
            }
        }
    }
}
