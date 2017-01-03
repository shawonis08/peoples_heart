using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace peoples_heart
{
    class textToSpeech
    {
        public textToSpeech()
        {
           
            
        }


        public void speak(String text)
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.Speak(text);
            }

        }
    }
}
