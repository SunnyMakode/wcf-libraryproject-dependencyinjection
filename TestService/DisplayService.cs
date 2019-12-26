using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestService.Utilities;

namespace TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DisplayService" in both code and config file together.
    public class DisplayService : IDisplayService
    {
        private readonly IStringMixer _mixer;

        public DisplayService(IStringMixer mixer)
        {
            _mixer = mixer;
        }

        public string DisplayInputValue(string input)
        {
            return _mixer.MixStringValue(input);
        }
    }
}
