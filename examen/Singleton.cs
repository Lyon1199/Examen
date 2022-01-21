﻿using System;
using System.Collections.Generic;
using System.Text;

namespace examen
{
   
        public class Singleton
        {
            private static Singleton instance = null;
            public string mensaje = "";

            protected Singleton()
            {
            mensaje = "LISTA DE ESTUDIANTE DE CURSO";

            }

            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                        instance = new Singleton();

                    return instance;
                }
            }

        }
}

