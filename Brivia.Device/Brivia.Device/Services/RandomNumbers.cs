using System;
using System.Collections.Generic;
using System.Text;

namespace Brivia.Device.Services
{
    public static class RandomNumbers
    {
        /// <summary>
        /// Devuelve un número aleatorio.
        /// </summary>
        /// <param name="max">Número máximo a generar</param>
        /// <returns></returns>
        public static int Random(int max)
        {
            return new Random().Next(max);
        }
    }
}
