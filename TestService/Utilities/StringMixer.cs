using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService.Utilities
{

    public class StringMixer : IStringMixer
    {
        /// <summary>
        /// This method deals with adding ""You've entered" before the passed input
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string MixStringValue(string value)
        {
            return $"You have entered {value}";
        }
    }
}
